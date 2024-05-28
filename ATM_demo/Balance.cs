using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Media;
namespace ATM_demo
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amin_stors\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30;");
        int balance;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum ='"+AccNumlbl.Text+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Rs " + dt.Rows[0][0].ToString();
            balance=Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        private string lang = Splash.lang;

        private async void Balance_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text=Home.AccNumber;
            getBalance();
            if (lang == "ky")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("сиздин эсебиңизде '"+balance+"' сом бар ", lang, "female");
            }
            else if (lang == "en")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("you have '"+balance+"' soms on your account", lang, "female");
            }

            else
            {
                await soundPlayer.PlayAndDeleteAudioAsync("на вашем счету '"+balance+"' сомов ", lang, "male");
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
