using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace ATM_demo
{
    internal class SoundPlayer
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "http://80.72.180.130:5050/api/tts";
        private WaveOutEvent _outputDevice;
        private CancellationTokenSource _cancellationTokenSource;
        private SynchronizationContext _uiContext;

        public SoundPlayer()
        {
            _httpClient = new HttpClient();
            _uiContext = SynchronizationContext.Current;
        }

        public async Task PlayAndDeleteAudioAsync(string text, string lang, string gender)
        {
            StopAudio();
            var audioData = await GetAudioAsync(text, lang, gender);
            await PlayAudioAsyncInternal(audioData);
        }

        public void StopAudio()
        {
            _cancellationTokenSource?.Cancel();
            _outputDevice?.Stop();
            _outputDevice?.Dispose();
            _outputDevice = null;
        }

        private async Task<byte[]> GetAudioAsync(string text, string lang, string gender)
        {
            var requestData = new
            {
                text = text,
                lang = lang,
                gender = gender
            };

            var json = JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_baseUrl, content);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }

        private async Task PlayAudioAsyncInternal(byte[] audioData)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            string tempFilePath = Path.GetTempFileName();
            await File.WriteAllBytesAsync(tempFilePath, audioData);

            if (_uiContext != null)
            {
                await Task.Run(() =>
                {
                    _uiContext.Send(_ =>
                    {
                        using (var audioFile = new AudioFileReader(tempFilePath))
                        using (var outputDevice = new WaveOutEvent())
                        {
                            _outputDevice = outputDevice;
                            outputDevice.Init(audioFile);
                            outputDevice.Play();

                            while (outputDevice.PlaybackState == PlaybackState.Playing && !_cancellationTokenSource.IsCancellationRequested)
                            {
                                Thread.Sleep(100);
                            }

                            if (_outputDevice != null)
                            {
                                outputDevice.Stop();
                            }
                        }
                    }, null);
                }, _cancellationTokenSource.Token);
            }
            else
            {
                // Воспроизведение аудио в отдельном потоке без использования SynchronizationContext
                await Task.Run(() =>
                {
                    using (var audioFile = new AudioFileReader(tempFilePath))
                    using (var outputDevice = new WaveOutEvent())
                    {
                        _outputDevice = outputDevice;
                        outputDevice.Init(audioFile);
                        outputDevice.Play();

                        while (outputDevice.PlaybackState == PlaybackState.Playing && !_cancellationTokenSource.IsCancellationRequested)
                        {
                            Thread.Sleep(100);
                        }

                        if (_outputDevice != null)
                        {
                            outputDevice.Stop();
                        }
                    }
                }, _cancellationTokenSource.Token);
            }

            File.Delete(tempFilePath);
        }
    }
}