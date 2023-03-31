using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Yemekhane_Kayıt_Programı
{
    public partial class Bakiye_Yükle : Form
    {
        public Kullanici _loginedUser;
        public Bakiye_Yükle()
        {
            InitializeComponent();
        }
        public Bakiye_Yükle(Kullanici loginedUser) : this()
        {
            _loginedUser = loginedUser;
        }

        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("server=.; Initial Catalog=Yemekhane_Kayit_programi;Integrated Security=True");


        public void kartlaodeme()
        {
            if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " ")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
            }

        }



        public void guncelle(string kartNo)
        {
            DialogResult Secim;
            Secim = MessageBox.Show("Yüklemek istediginiz tutar " + txt_miktar.Text + " TL mi?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Secim == DialogResult.Yes)
            {
                con.Open();
                string sorgu = $"Update Kartlar SET bakiye= bakiye + {txt_miktar.Text}  Where Kart_no= '{kartNo}'";
                cmd = new SqlCommand(sorgu);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bakiye yüklenmiştir");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnykl_Click(object sender, EventArgs e)
        {
            kartlaodeme();
            guncelle(_loginedUser.kart_No);
        }

    }
}

