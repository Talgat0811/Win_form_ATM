namespace ATM_demo
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        public static String lang;

        private void Splash_Load(object sender, EventArgs e)
        {
            soundPlayer.PlayAndDeleteAudioAsync("Кош келиниздер, колдонгон тил танданыз", "ky", "female");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string selectedLanguage = "ky"; 

            if (enlng.Checked)
            {
                selectedLanguage = "en";
            }
            else if (rulng.Checked)
            {
                selectedLanguage = "ru";
            }

            lang = selectedLanguage;
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
