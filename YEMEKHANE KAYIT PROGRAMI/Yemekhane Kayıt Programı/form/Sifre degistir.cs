using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Yemekhane_Kayıt_Programı.form
{
    public partial class Sifre_degistir : Form
    {
        private readonly Kullanici _user;
        public Sifre_degistir(Kullanici user)
        {
            _user = user;
            InitializeComponent();
        }

        VtConnection bgl = new VtConnection();

        SqlConnection con;
        
        SqlDataReader dr;


        public void SifreDeğiştir()
        {
            con = new SqlConnection("server=.; Initial Catalog=Yemekhane_Kayit_programi;Integrated Security=True");
            try
            {
                con.Open();
                
                string kayit = $"update Kullanicilar set sifre=@Sifre where tc_kimlik=@Tc_Kimlik";
                SqlCommand guncelle = new SqlCommand(kayit, con);
                guncelle.Parameters.AddWithValue("@Sifre", textBox2.Text);
                guncelle.Parameters.AddWithValue("@Tc_Kimlik", _user.tc_kimlik);

                guncelle.ExecuteNonQuery();
                con.Close();

                lblkart.Text = "Şifre Başarıyla Değiştirildi";
            }
            catch (Exception e)
            {
                string message = e.InnerException != null ? e.InnerException.Message : e.Message;

                lblkart.Text = $"Şifre Değiştirme Hatası:{message}";
            }


        }

        private void Sifre_degistir_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("server=.; Initial Catalog=Yemekhane_Kayit_programi;Integrated Security=True");
            checkBox1.Checked = false;

            try
            {
                SqlCommand mevcutsifre = new SqlCommand();
                con.Open();
                mevcutsifre.Connection = con;
                mevcutsifre.CommandText = "select * from Kullanicilar where Kart_no='"+label4.Text + "'";
                SqlDataReader dr = mevcutsifre.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["sifre"].ToString();
                }
                con.Close();
            }
            catch (Exception)
            {
                lblkart.Visible = true;
                lblkart.ForeColor = Color.Red;
                lblkart.Text = "Mevcut Şifre Getirilemiyor";

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox1.UseSystemPasswordChar = true;
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                if (textBox2.Text != "" && textBox3.Text != "" && textBox1.Text != "")
                {
                    SifreDeğiştir();
                }
                else
                {
                    lblkart.Visible = true;
                    lblkart.ForeColor = Color.Red;
                    lblkart.Text = "Alanları Boş Bırakmayınız";
                }
            }
            else
            {
                lblkart.Visible = true;
                lblkart.ForeColor = Color.Red;
                lblkart.Text = "Şifreler Eşleşmiyor";
            }
        }

        Müşteri_Bilgileri musteridonus = new Müşteri_Bilgileri();
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            
            this.Hide();
          
            
        }
    }
}
