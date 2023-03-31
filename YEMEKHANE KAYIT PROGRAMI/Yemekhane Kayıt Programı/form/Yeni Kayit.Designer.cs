
namespace Yemekhane_Kayıt_Programı.form
{
    partial class Yeni_Kayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_Adi = new System.Windows.Forms.Label();
            this.lbl_soyadi = new System.Windows.Forms.Label();
            this.lbl_Kartno = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_Soyadi = new System.Windows.Forms.TextBox();
            this.txt_kartno = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.chc_goster = new System.Windows.Forms.CheckBox();
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(51, 68);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(56, 13);
            this.lbl_tc.TabIndex = 5;
            this.lbl_tc.Text = "Tc_Kimlik:";
            // 
            // lbl_Adi
            // 
            this.lbl_Adi.AutoSize = true;
            this.lbl_Adi.Location = new System.Drawing.Point(50, 116);
            this.lbl_Adi.Name = "lbl_Adi";
            this.lbl_Adi.Size = new System.Drawing.Size(25, 13);
            this.lbl_Adi.TabIndex = 6;
            this.lbl_Adi.Text = "Adı:";
            // 
            // lbl_soyadi
            // 
            this.lbl_soyadi.AutoSize = true;
            this.lbl_soyadi.Location = new System.Drawing.Point(44, 156);
            this.lbl_soyadi.Name = "lbl_soyadi";
            this.lbl_soyadi.Size = new System.Drawing.Size(42, 13);
            this.lbl_soyadi.TabIndex = 7;
            this.lbl_soyadi.Text = "Soyadı:";
            // 
            // lbl_Kartno
            // 
            this.lbl_Kartno.AutoSize = true;
            this.lbl_Kartno.Location = new System.Drawing.Point(44, 204);
            this.lbl_Kartno.Name = "lbl_Kartno";
            this.lbl_Kartno.Size = new System.Drawing.Size(49, 13);
            this.lbl_Kartno.TabIndex = 8;
            this.lbl_Kartno.Text = "Kart_No:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(50, 242);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(31, 13);
            this.lbl_Sifre.TabIndex = 9;
            this.lbl_Sifre.Text = "Sifre:";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(129, 68);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(100, 20);
            this.txt_tc.TabIndex = 0;
            this.txt_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tc_KeyPress_1);
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(129, 116);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 1;
            // 
            // txt_Soyadi
            // 
            this.txt_Soyadi.Location = new System.Drawing.Point(129, 156);
            this.txt_Soyadi.Name = "txt_Soyadi";
            this.txt_Soyadi.Size = new System.Drawing.Size(100, 20);
            this.txt_Soyadi.TabIndex = 2;
            // 
            // txt_kartno
            // 
            this.txt_kartno.Location = new System.Drawing.Point(129, 204);
            this.txt_kartno.MaxLength = 6;
            this.txt_kartno.Name = "txt_kartno";
            this.txt_kartno.Size = new System.Drawing.Size(100, 20);
            this.txt_kartno.TabIndex = 3;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(129, 241);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_Sifre.TabIndex = 4;
            this.txt_Sifre.UseSystemPasswordChar = true;
            // 
            // chc_goster
            // 
            this.chc_goster.AutoSize = true;
            this.chc_goster.Location = new System.Drawing.Point(235, 241);
            this.chc_goster.Name = "chc_goster";
            this.chc_goster.Size = new System.Drawing.Size(57, 17);
            this.chc_goster.TabIndex = 3;
            this.chc_goster.Text = "Göster";
            this.chc_goster.UseVisualStyleBackColor = true;
            this.chc_goster.CheckedChanged += new System.EventHandler(this.chc_goster_CheckedChanged);
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_kayıt.FlatAppearance.BorderSize = 2;
            this.btn_kayıt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_kayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayıt.Location = new System.Drawing.Point(84, 318);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(287, 98);
            this.btn_kayıt.TabIndex = 4;
            this.btn_kayıt.Text = "ÜYE OL";
            this.btn_kayıt.UseVisualStyleBackColor = true;
            this.btn_kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Yeni_Kayit
            // 
            this.AcceptButton = this.btn_kayıt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(438, 438);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_kayıt);
            this.Controls.Add(this.chc_goster);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_kartno);
            this.Controls.Add(this.txt_Soyadi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_Kartno);
            this.Controls.Add(this.lbl_soyadi);
            this.Controls.Add(this.lbl_Adi);
            this.Controls.Add(this.lbl_tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Yeni_Kayit";
            this.Text = "Yeni_Kayit";
            this.Load += new System.EventHandler(this.Yeni_Kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_Adi;
        private System.Windows.Forms.Label lbl_soyadi;
        private System.Windows.Forms.Label lbl_Kartno;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_Soyadi;
        private System.Windows.Forms.TextBox txt_kartno;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.CheckBox chc_goster;
        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}