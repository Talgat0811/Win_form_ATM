using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_demo
{
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        private string lang = Splash.lang;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amin_stors\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30;");
        string Acc = Login.AccNumber;
        int bal, newBalance;
        private void addtransaction(int sum)
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TtansactionTbl values('"+Acc+"','"+TrType+"',"+sum+",'"+DateTime.Today.Date.ToLocalTime().ToString()+"')";
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

        private void label6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private async void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
            if (lang == "ky")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Сиз учурда акча чыгаруу бөлүмүндөсүңөр ! ", lang, "female");
            }
            else if (lang == "en")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("You are currently in the withdraw section ! ", lang, "female");
            }

            else
            {
                await soundPlayer.PlayAndDeleteAudioAsync("В данный момент вы находитесь в разделе вывода денег! ", lang, "male");
            }
        }
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum ='"+Acc+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            avBalancelbl.Text = "Balance Rs " + dt.Rows[0][0].ToString();
            bal =Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (bal<100)
            {
                balanceNegative();
            }
            else
            {
                newBalance=bal-100;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance="+newBalance+" where Accnum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    
                    Con.Close();
                    addtransaction(100);
                    successWithDraw(100);
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
        public async void balanceNegative()
        {
            if (lang == "ky")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Картаңыздагы баланс терс болушу мүмкүн эмес! ", lang, "female");
            }
            else if (lang == "en")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("The balance on your card cannot be negative! ", lang, "female");
            }

            else
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Баланс на вашей карте не может быть отрицательным", lang, "male");
            }
        }
        public async void successWithDraw(int sum)
        {
            if (lang == "ky")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Сиздин эсебиңизден '"+sum+"' сом ийгиликтүү алынды ! ", lang, "female");
            }
            else if (lang == "en")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("'"+sum+"' soms have been successfully withdrawn from your account ! ", lang, "female");
            }

            else
            {
                await soundPlayer.PlayAndDeleteAudioAsync("С вашего счета успешно сняты '"+sum+"' сомов", lang, "male");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (bal<500)
            {
                balanceNegative();
            }
            else
            {
                newBalance=bal-500;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance="+newBalance+" where Accnum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction(500);
                    successWithDraw(500);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal<1000)
            {
                balanceNegative();
            }
            else
            {
                newBalance=bal-1000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance="+newBalance+" where Accnum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction(1000);
                    successWithDraw(1000);
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal<2000)
            {
                balanceNegative();
            }
            else
            {
                newBalance=bal-2000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance="+newBalance+" where Accnum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction(2000);
                    successWithDraw(2000);
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (bal<5000)
            {
                balanceNegative();
            }
            else
            {
                newBalance=bal-5000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance="+newBalance+" where Accnum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction(5000);
                    successWithDraw(5000);
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (bal<10000)
            {
                balanceNegative();
            }
            else
            {
                newBalance=bal-10000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance="+newBalance+" where Accnum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction(10000);
                    successWithDraw(10000);
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

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
