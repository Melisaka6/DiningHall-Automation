using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemekhane_Kayıt_Programı.form
{
    public partial class FiyatListesi : Form
    {
        public FiyatListesi()
        {
            InitializeComponent();
        }

        private void chc_ogretmen_CheckedChanged(object sender, EventArgs e)
        {
            if(chc_ogretmen.Checked)
            {
                txtogretmen.Text="10TL";
                chc_ogrenci.Checked = false;
                chcıdarı.Checked = false;

            }

        }

        private void chc_ogrenci_CheckedChanged(object sender, EventArgs e)
        {
            if(chc_ogrenci.Checked)
            {
                txtogretmen.Text = "4TL";
                chcıdarı.Checked = false;
                chc_ogretmen.Checked = false;
            }
        }

        private void chcıdarı_CheckedChanged(object sender, EventArgs e)
        {
            if (chcıdarı.Checked)
            {
                txtogretmen.Text = "8TL";
                chc_ogretmen.Checked = false;
                chc_ogrenci.Checked = false;

            }

        }

        private void FiyatListesi_Load(object sender, EventArgs e)
        {
            txtogretmen.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yemek_Listesi frm7 = new Yemek_Listesi();
            frm7.ShowDialog();
            Hide();
        }
    }
}
