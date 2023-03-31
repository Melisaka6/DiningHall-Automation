using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Yemekhane_Kayıt_Programı.form
{
    public partial class Yeni_Kayit : Form
    {
        public Yeni_Kayit()
        {
            InitializeComponent();
        }
        VtConnection bgl = new VtConnection();

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        string kullanicituru;


        public bool bosgecilmez()
        {
            if (txt_adi.Text == "" || txt_Soyadi.Text == "" || txt_tc.Text == "" || txt_kartno.Text == "" || txt_Sifre.Text == "" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                return false;
            }
            else
            {
                return true;
            }


        }
        private void chc_goster_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_goster.Checked)
            {
                txt_Sifre.UseSystemPasswordChar = false;

            }
            else
            {
                txt_Sifre.UseSystemPasswordChar = true;
            }
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("server=.; Initial Catalog=Yemekhane_Kayit_programi;Integrated Security=True");
            con.Open();
            bool uyeEklemeBasariDurumu = false;
            try
            {
                string kartno = txt_kartno.Text;
                string adi = txt_adi.Text;
                string şifre = txt_Soyadi.Text;
                int kullanici_tipi = (int)comboBox1.SelectedValue;
                bool BasariDurumu = bosgecilmez();
                if (BasariDurumu == true)
                {
                    cmd = new SqlCommand("INSERT INTO Kullanicilar (tc_kimlik,Adi,Soyadi,Kart_no,Sifre,kullanici_tipi) Values(@tc_kimlik,@Adi,@Soyadi,@Kart_no,@Sifre,@kullanici_tipi)", con);
                    cmd.Parameters.AddWithValue("@tc_kimlik", txt_tc.Text);
                    cmd.Parameters.AddWithValue("@Adi", txt_adi.Text);
                    cmd.Parameters.AddWithValue("@Soyadi", txt_Soyadi.Text);
                    cmd.Parameters.AddWithValue("@Kart_no", txt_kartno.Text);
                    cmd.Parameters.AddWithValue("@Sifre", txt_Sifre.Text);
                    cmd.Parameters.AddWithValue("@kullanici_tipi", kullanici_tipi);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("INSERT INTO Kartlar (Kart_no,Bakiye) Values(@Kart_no,@Bakiye)", con);
                    cmd.Parameters.AddWithValue("@Kart_no",txt_kartno.Text);
                    cmd.Parameters.AddWithValue("@Bakiye", 0);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("kayıt oluşturuldu");
                    var log = new Log()
                    {
                        Id=new Guid (),
                        FormName = "Yeni Kayıt",
                        OlayBaslik = "Yeni Kullanıcı Oluşturma",
                        OlayAciklama = $"Tc Kimlik Numaralı:{txt_tc.Text} olan ve Adı:{txt_adi.Text} Soyadı:{txt_Soyadi.Text} kullanıcı  kayıt oldu .",
                        OlayTarihi = DateTime.Now
                    };
                    Müşteri_Bilgileri.LogEkle(log);
                    con.Close();
                    uyeEklemeBasariDurumu = true; 
                    this.Close();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("LÜTFEN ALANLARI BOŞ BIRAKMAYINIZ VE KONTROL EDİNİZ.. " + ex.Message);
            }

            

            if (uyeEklemeBasariDurumu)
            {
                Kullanıcıgirisekrani frm = new Kullanıcıgirisekrani();
                frm.Show();
                this.Hide();
            }
            
        }

        private void Yeni_Kayit_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Kullanici_Tipi));
        }
        private void txt_tc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }
       
    }
}



