using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Yemekhane_Kayıt_Programı.form;

namespace Yemekhane_Kayıt_Programı
{
    public partial class Müşteri_Bilgileri : Form
    {
        public Kullanici _loginedUser;
        Bakiye_Yükle bakiyeForm;
        public Müşteri_Bilgileri()
        {
            InitializeComponent();
        }
        public Müşteri_Bilgileri(Kullanici loginUser) : this()
        {
            _loginedUser = loginUser;
            bakiyeForm = new Bakiye_Yükle(_loginedUser);
        }


        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;


       public  string gelen;

        void bakiyegoruntule()
        {
            string sorgu = $"SELECT bakiye FROM Kartlar where Kart_No = '{_loginedUser.kart_No}'";
            con = new SqlConnection("server=.; Initial Catalog=Yemekhane_Kayit_programi;Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@bakiye", txt_bakiye.Text);

            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txt_bakiye.Text = dr["bakiye"].ToString();
            }

        }

        public static bool LogEkle(Log log)
        {
            con = new SqlConnection("server=.; Initial Catalog=Yemekhane_Kayit_programi;Integrated Security=True");
            con.Open();
            bool logEklenmeBasariDurumu = false;
            try
            {
                
               
                    cmd = new SqlCommand("INSERT INTO Log (Tc_Kimlik,OlayTarihi,FormName,OlayBaslik,OlayAciklama) Values(@Tc_Kimlik,@OlayTarihi,@FormName,@OlayBaslik,@OlayAciklama)", con);
                    cmd.Parameters.AddWithValue("@Tc_Kimlik", log.Tc_Kimlik);
                    cmd.Parameters.AddWithValue("@OlayTarihi", log.OlayTarihi);
                    cmd.Parameters.AddWithValue("@FormName", log.FormName);
                    cmd.Parameters.AddWithValue("@OlayBaslik", log.OlayBaslik);
                    cmd.Parameters.AddWithValue("@OlayAciklama", log.OlayAciklama);
                    

                    cmd.ExecuteNonQuery();

                logEklenmeBasariDurumu= true;

                    con.Close();
                   
            }
            catch (Exception ex)
            {
                logEklenmeBasariDurumu = false;
                MessageBox.Show("LÜTFEN ALANLARI BOŞ BIRAKMAYINIZ VE KONTROL EDİNİZ.. " + ex.Message);
            }
            
                return logEklenmeBasariDurumu;
            


        }


        private void btnykle_Click(object sender, EventArgs e)
        {
            
            bakiyeForm.ShowDialog();
            
        }

        private void btn_yemeklist(object sender, EventArgs e)
        {
            Yemek_Listesi frm4 = new Yemek_Listesi();
            frm4.ShowDialog();
            
        }

        private void btngoruntule_Click(object sender, EventArgs e)
        {
            bakiyegoruntule();
        }

        private void Müşteri_Bilgileri_Load(object sender, EventArgs e)
        {
            txt_bakiye.ReadOnly = true;
            txtkartno.Text = _loginedUser.kart_No;
            if (Kullanıcıgirisekrani.SifreDegistirButonunuGizle)
                btnSifreDegistir.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sifre_degistir frm9 = new Sifre_degistir(_loginedUser);
            frm9.ShowDialog();
            
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Kullanıcıgirisekrani frm9 = new Kullanıcıgirisekrani();
            this.Hide();
            frm9.ShowDialog();
             
        }
    }
    }

