using System;
using System.Data;
using System.Data.SqlClient;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_demo
{
    public partial class Login : Form
    {
        private string lang = Splash.lang;
        public static string AccNumber;
        public static string UserName;
        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amin_stors\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30;");
        private SoundPlayer soundPlayer = new SoundPlayer();

        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand command = new SqlCommand("SELECT count(*) FROM AccountTbl WHERE Accnum = @AccNum AND PIN = @Pin", Con);
                command.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                command.Parameters.AddWithValue("@Pin", PinTb.Text);

                int count = (int)command.ExecuteScalar();

                if (count == 1)
                {
                    SqlCommand getNameCommand = new SqlCommand("SELECT Name FROM AccountTbl WHERE Accnum = @AccNum AND PIN = @Pin", Con);
                    getNameCommand.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    getNameCommand.Parameters.AddWithValue("@Pin", PinTb.Text);

                    string name = getNameCommand.ExecuteScalar().ToString();

                    AccNumber = AccNumTb.Text;
                    UserName = name;

                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    string message = (lang == "ky") ? "Туура эмес эсеп номер же ПИН код" : (lang == "en") ? "Wrong Account Number Or PIN Code" : "Неправильный номер или пин-код!";
                    await soundPlayer.PlayAndDeleteAudioAsync(message, lang, (lang == "ky" || lang == "en") ? "female" : "male");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            try
            {
                if (lang == "ky")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Картаңыздын номерин жана ПИН кодун киргизиңиз!", lang, "female");
                }
                else if (lang == "en")
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Enter your card number and PIN code!", lang, "female");
                }
                else
                {
                    await soundPlayer.PlayAndDeleteAudioAsync("Введите номер вашей карты и PIN-код! ", lang, "male");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
