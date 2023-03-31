using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yemekhane_Kayıt_Programı.form;
using System.Data.SqlClient; 

namespace Yemekhane_Kayıt_Programı
{
    public partial class Yemek_Listesi : Form
    {
        public Yemek_Listesi()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable tablo; 


        private void btnfiyat_Click(object sender, EventArgs e)
        {
            FiyatListesi frm5 = new FiyatListesi(); 
            frm5.ShowDialog();
            
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            //Müşteri_Bilgileri frm6 = new Müşteri_Bilgileri();
            //frm6.ShowDialog();
            this.Hide();
        }
        public void goster()
        {
            con = new SqlConnection("server=.; Initial Catalog=Yemekhane_Kayit_programi;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * From Yemekler", con);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
        }
   
        

        private void btn_goster_Click(object sender, EventArgs e)
        {
            goster(); 
        
            
        }
    }
}
