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
using System.Data.SqlTypes;
using System.Media;

namespace ATM_demo
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amin_stors\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30;");


        private async void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNameTb.Text=="" || AccNumTb.Text=="" || FanameTb.Text=="" || PhoneTb.Text =="" || Addresstb.Text=="" || occupationtb.Text=="" || pintb.Text=="")
            {
                if (lang == "ky")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Банк эсеби Ийгиликтүү Түзүлгөн", lang, "female");
                }
                else if (lang == "en")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Bank Account Created Successfuly", lang, "female");
                }
                else
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Банк Эсеби Ийгиликтүү Түзүлгөн", lang, "male");
                }
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('"+AccNumTb.Text+"','"+AccNameTb.Text+"','"+FanameTb.Text+"','"+dobdate.Value.Date+"','"+PhoneTb.Text+"','"+Addresstb.Text+"','"+educationtb.SelectedItem.ToString()+"','"+occupationtb.Text+"',"+pintb.Text+","+bal+")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    Console.WriteLine(query);
                    cmd.ExecuteNonQuery();
                    if (lang == "ky")
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("Банк эсеби Ийгиликтүү Түзүлгөн", lang, "female");
                    }
                    else if (lang == "en")
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("Bank Account Created Successfuly", lang, "female");
                    }
                    else
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("Банк Эсеби Ийгиликтүү Түзүлгөн", lang, "male");
                    }
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        private string lang = Splash.lang;
        private  async void Account_Load(object sender, EventArgs e)
        {
            if (lang == "ky")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Банк эсебин түзүү үчүн бардык талааларды толтуруңуз", lang, "female");
            }
            else if (lang == "en")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Fill in all the fields to create a bank account", lang, "female");
            }
            else
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Заполните все поля для создания банковского счета", lang, "male");
            }

            Con.Close();
        }
    }
}
