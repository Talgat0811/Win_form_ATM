using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_demo
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        SoundPlayer soundPlayer = new SoundPlayer();
        private string lang = Splash.lang;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amin_stors\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30;");
        string Acc = Login.AccNumber;
        private async void button1_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text=="" || Pin2Tb.Text=="")
            {
                if (lang == "ky")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Жаңы пин код киргизип, ырастаңыз' ! ", lang, "female");
                }
                else if (lang == "en")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Enter and confirm the new pin", lang, "female");
                }

                else
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Введите и подтвердите новый Пин-Код", lang, "male");
                }
            }
            else if (Pin2Tb.Text != Pin1Tb.Text)
            {
                if (lang == "ky")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Пин 1 жана Пин 2 ар башка", lang, "female");
                }
                else if (lang == "en")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Pin1 and Pin2 are Different ", lang, "female");
                }

                else
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Пин-код 1 и пин-код 2 отличаются друг от друга ", lang, "male");
                }
            }
            else
            {

                try
                {
                    Con.Open();
                    string query = "update AccountTbl set PIN="+Pin1Tb.Text+" where Accnum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    if (lang == "ky")
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("Пин код ийгиликтүү өзгөртүлдү ! ", lang, "female");
                    }
                    else if (lang == "en")
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("The PIN code has been successfully changed! ", lang, "female");
                    }

                    else
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("PIN-код был успешно изменен ", lang, "male");
                    }
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private async void ChangePin_Load(object sender, EventArgs e)
        {
            if (lang == "ky")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Пин код өзгөртүү бөлүмүндөсүз! ", lang, "female");
            }
            else if (lang == "en")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("You are in the PIN code changes section ", lang, "female");
            }

            else
            {
                await soundPlayer.PlayAndDeleteAudioAsync(" Вы в разделе изменения PIN-кода", lang, "male");
            }
        }
    }
}
