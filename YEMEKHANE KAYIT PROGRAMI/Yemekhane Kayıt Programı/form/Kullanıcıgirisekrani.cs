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
using Yemekhane_Kayıt_Programı.form;

namespace Yemekhane_Kayıt_Programı
{
    public partial class Kullanıcıgirisekrani : Form
    {
        public Kullanıcıgirisekrani()
        {
            InitializeComponent();
        }


        public static bool SifreDegistirButonunuGizle = false;

        VtConnection bgl = new VtConnection();

        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader dr;

        public void login()
        {
            string query = "SELECT * FROM kullanicilar where Kart_no=@user AND Sifre=@pass";
            connection = new SqlConnection("server=.; Initial Catalog=Yemekhane_Kayit_programi;Integrated Security=True");
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@user", txt_kartno.Text);
            cmd.Parameters.AddWithValue("@pass", txt_şifre.Text);
            connection.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Hoşgeldiniz! " + dr["Adi"].ToString() + " Başarılı bir şekilde giriş yaptınız...", "HOŞGELDİNİZ", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                
                lblkartno.Text = Convert.ToString(dr["Kart_no"]);
                if (dr["kullanici_tipi"].ToString() == "1")
                {
                    SifreDegistirButonunuGizle = true;
                }
                Müşteri_Bilgileri frm2 = new Müşteri_Bilgileri(new Kullanici() 
                {
                    tc_kimlik = dr["tc_kimlik"].ToString(),
                    adi = dr["Adi"].ToString(),
                    soyadi = dr["Soyadi"].ToString(),
                    kart_No = dr["Kart_no"].ToString(),
            });
                frm2.Show();
                this.Hide();

                frm2.gelen = Convert.ToString(dr["Kart_no"]);
            }
            else
            {
                MessageBox.Show("Kart numaranızı  ve şifrenizi kontrol ediniz.", "TEKRAR DENEYİN ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txt_kartno.Clear();
                txt_şifre.Clear();
            }
            connection.Close();

        }



      


        public void btn_giris_Click(object sender, EventArgs e)
        {
            login();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://uludag.edu.tr/konu/view/14/iletisim");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_şifre.UseSystemPasswordChar = false;

            }
            else
            {
                txt_şifre.UseSystemPasswordChar = true;
            }
        }

        private void btn_uyelik_Click(object sender, EventArgs e)
        {
            Yeni_Kayit frm8 = new Yeni_Kayit();
            this.Hide();
            frm8.ShowDialog();
        }

       
    }
}





