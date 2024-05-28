using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_demo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private string lang = Splash.lang;
        SoundPlayer soundPlayer = new SoundPlayer();
        private void label5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            this.Hide();
            balance.Show();
        }
        public static String AccNumber;
        public static String UserName;
        private async void Home_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text="Account Number: " + Login.AccNumber;
            AccNumber=Login.AccNumber;
            UserName = Login.UserName;
            if (lang == "ky")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Саламатсызбы,"+UserName+", сиз учурда негизги менюда турасыз", lang, "female");
            }
            else if (lang == "en")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Hello ,'"+UserName+"',you are currently in the main menu", lang, "female");
            }
            else
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Здравствуйте,'"+UserName+"', сейчас вы находитесь в главном меню", lang, "male");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin();
            pin.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            FastCash fastCash = new FastCash();
            fastCash.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MiniStatment miniStatment = new MiniStatment();
            miniStatment.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
