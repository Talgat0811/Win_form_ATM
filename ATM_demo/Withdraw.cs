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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        private string lang = Splash.lang;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amin_stors\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30;");
        int bal;
        private async void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
            if (lang == "ky")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Сиз учурда акча чыгаруу бөлүмүндөсүңөр ! ", lang, "female");
            }
            else if (lang == "en")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("You are currently in the withdraw section! ", lang, "female");
            }

            else
            {
                await soundPlayer.PlayAndDeleteAudioAsync("В данный момент вы находитесь в разделе вывода денег! ", lang, "male");
            }
        }
        string Acc = Login.AccNumber;
        int newBalance;
        int withdraw;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum ='"+Acc+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            withdrawlbl.Text = "Balance Rs " + dt.Rows[0][0].ToString();
            bal =Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void addtransaction()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TtansactionTbl values('"+Acc+"','"+TrType+"',"+wdarntTb.Text+",'"+DateTime.Today.Date.ToLocalTime().ToString()+"')";
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
            withdraw= Convert.ToInt32(wdarntTb.Text);
            if (wdarntTb.Text=="")
            {
                if (lang == "ky")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Канча акча алгыңыз келерин киргизиңиз! ", lang, "female");
                }
                else if (lang == "en")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Enter how much money you would like to withdraw! ", lang, "female");
                }

                else
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Введите сколько вы хотели бы снять денег! ", lang, "male");
                }
            }
            else if (Convert.ToInt32(wdarntTb.Text)<=0)
            {
                if (lang == "ky")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Алгыныз келген туура сумманы киргизиңиз! ", lang, "female");
                }
                else if (lang == "en")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Enter the correct amount you want to withdraw ! ", lang, "female");
                }

                else
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Введите правильную сумму которую хотите снять! ", lang, "male");
                }
                MessageBox.Show("Enter a Valid amount");
            }
            else if (Convert.ToInt32(wdarntTb.Text)>bal)
            {
                if (lang == "ky")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Картаңыздагы баланс терс болушу мүмкүн эмес", lang, "female");
                }
                else if (lang == "en")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("The balance on your card cannot be negative ! ", lang, "female");
                }

                else
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Баланс на вашей карте не может быть отрицательным ! ", lang, "male");
                }
            }
            else
            {
                newBalance=bal-Convert.ToInt32(wdarntTb.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance="+newBalance+" where Accnum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    addtransaction();
                    Home home = new Home();
                    home.Show();
                    if (lang == "ky")
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("'"+withdraw+"' сом Сиздин эсебиңизден ийгиликтүү алынып салынды ", lang, "female");
                    }
                    else if (lang == "en")
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("'"+withdraw+"' soms has been successfully withdrawn from your account", lang, "female");
                    }

                    else
                    {
                        await soundPlayer.PlayAndDeleteAudioAsync("'"+withdraw+"' сомов были успешно сняты с вашего счета ", lang, "male");
                    }
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
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
