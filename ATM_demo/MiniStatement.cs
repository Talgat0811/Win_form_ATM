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
    public partial class MiniStatment : Form
    {
        public MiniStatment()
        {
            InitializeComponent();
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        private string lang = Splash.lang;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amin_stors\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30;");
        string Acc = Login.AccNumber;

        private void populate()
        {
            Con.Open();
            string query = "select * from TtansactionTbl where AccNum='"+Acc+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MiniStatementDGV.DataSource=ds.Tables[0];
            Con.Close();
        }
        private async void MiniStatment_Load(object sender, EventArgs e)
        {
            populate();
            if (lang == "ky")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Сиз мини отчеттор бөлүмүндөсүз! ", lang, "female");
            }
            else if (lang == "en")
            {
                await soundPlayer.PlayAndDeleteAudioAsync("You are in the mini-reports section! ", lang, "female");
            }

            else
            {
                await soundPlayer.PlayAndDeleteAudioAsync("Вы находитесь в разделе мини-отчетов! ", lang, "male");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home home=new Home();
            home.Show();
            this.Hide();
        }
    }
}
