
namespace Yemekhane_Kayıt_Programı
{
    partial class Kullanıcıgirisekrani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanıcıgirisekrani));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kartno = new System.Windows.Forms.TextBox();
            this.txt_şifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_uyelik = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblkartno = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kart_No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txt_kartno
            // 
            this.txt_kartno.BackColor = System.Drawing.Color.White;
            this.txt_kartno.Location = new System.Drawing.Point(67, 89);
            this.txt_kartno.Name = "txt_kartno";
            this.txt_kartno.Size = new System.Drawing.Size(134, 20);
            this.txt_kartno.TabIndex = 1;
            // 
            // txt_şifre
            // 
            this.txt_şifre.ForeColor = System.Drawing.Color.Black;
            this.txt_şifre.Location = new System.Drawing.Point(67, 165);
            this.txt_şifre.Name = "txt_şifre";
            this.txt_şifre.Size = new System.Drawing.Size(134, 20);
            this.txt_şifre.TabIndex = 2;
            this.txt_şifre.UseSystemPasswordChar = true;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.White;
            this.btn_giris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_giris.FlatAppearance.BorderSize = 3;
            this.btn_giris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_giris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Location = new System.Drawing.Point(45, 256);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(168, 55);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-eye-unchecked-50.png");
            this.ımageList1.Images.SetKeyName(1, "images.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-eye-64.png");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 497);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(310, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bir sorun olduğunu mu düşünüyorsunuz ?  Bizimle iletişime geçin.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_uyelik
            // 
            this.btn_uyelik.BackColor = System.Drawing.Color.White;
            this.btn_uyelik.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_uyelik.FlatAppearance.BorderSize = 3;
            this.btn_uyelik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_uyelik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uyelik.Location = new System.Drawing.Point(478, 12);
            this.btn_uyelik.Name = "btn_uyelik";
            this.btn_uyelik.Size = new System.Drawing.Size(173, 25);
            this.btn_uyelik.TabIndex = 7;
            this.btn_uyelik.Text = "ÜYELİK OLUŞTUR ";
            this.btn_uyelik.UseVisualStyleBackColor = false;
            this.btn_uyelik.Click += new System.EventHandler(this.btn_uyelik_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(207, 164);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblkartno
            // 
            this.lblkartno.AutoSize = true;
            this.lblkartno.Location = new System.Drawing.Point(22, 397);
            this.lblkartno.Name = "lblkartno";
            this.lblkartno.Size = new System.Drawing.Size(0, 13);
            this.lblkartno.TabIndex = 9;
            // 
            // Kullanıcıgirisekrani
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 519);
            this.Controls.Add(this.lblkartno);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_uyelik);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_şifre);
            this.Controls.Add(this.txt_kartno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Kullanıcıgirisekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici Giriş Ekranı";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kartno;
        private System.Windows.Forms.TextBox txt_şifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_uyelik;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Label lblkartno;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

