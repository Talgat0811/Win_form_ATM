using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_demo
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amin_stors\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30;");
        string Acc = Login.AccNumber;
        SoundPlayer soundPlayer = new SoundPlayer();
        private string lang = Splash.lang;
        private void addtransaction()
        {
            string TrType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TtansactionTbl values('"+Acc+"','"+TrType+"',"+DepositAmtTb.Text+",'"+DateTime.Today.Date.ToLocalTime().ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                Console.WriteLine(query);
                cmd.ExecuteNonQuery();
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (DepositAmtTb.Text=="" || Convert.ToInt32(DepositAmtTb.Text)<=0)
            {
                if (lang == "ky")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Акча кошуу үчүн сумманы киргизиңиз ", lang, "female");
                }
                else if (lang == "en")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Enter the Amount to Deposit Please ", lang, "female");
                }

                else
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Введите сумму для внесения депозита", lang, "male");
                }
            }
            else
            {

                newBalance=oldBalance+Convert.ToInt32(DepositAmtTb.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance="+newBalance+" where Accnum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    if (lang == "ky")
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("Депозитиңиз кабыл алынды ", lang, "female");
                    }
                    else if (lang == "en")
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("Your deposit has been accepted ! ", lang, "female");
                    }

                    else
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("Ваш депозит был принят ! ", lang, "male");
                    }
                    Con.Close();
                    addtransaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        int oldBalance, newBalance;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum ='"+Acc+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBalance=Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private async void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
            if (lang == "ky")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Сиз учурда депозиттер бөлүмүндөсүңөр! ", lang, "female");
            }
            else if (lang == "en")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("You are currently in the deposits section! ", lang, "female");
            }

            else
            {
                await soundPlayer.PlayAndDeleteAudioAsync("В данный момент вы находитесь в разделе депозиты ", lang, "male");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
