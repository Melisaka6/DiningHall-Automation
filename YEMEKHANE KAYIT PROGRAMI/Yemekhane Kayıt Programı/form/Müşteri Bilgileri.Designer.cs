
namespace Yemekhane_Kayıt_Programı
{
    partial class Müşteri_Bilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Müşteri_Bilgileri));
            this.btngoruntule = new System.Windows.Forms.Button();
            this.btnykle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.txt_bakiye = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.txtkartno = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngoruntule
            // 
            this.btngoruntule.BackColor = System.Drawing.Color.LightSalmon;
            this.btngoruntule.Location = new System.Drawing.Point(12, 70);
            this.btngoruntule.Name = "btngoruntule";
            this.btngoruntule.Size = new System.Drawing.Size(132, 83);
            this.btngoruntule.TabIndex = 0;
            this.btngoruntule.Text = "Bakiye Görüntüle";
            this.btngoruntule.UseVisualStyleBackColor = false;
            this.btngoruntule.Click += new System.EventHandler(this.btngoruntule_Click);
            // 
            // btnykle
            // 
            this.btnykle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnykle.BackColor = System.Drawing.Color.LightSalmon;
            this.btnykle.Location = new System.Drawing.Point(12, 336);
            this.btnykle.Name = "btnykle";
            this.btnykle.Size = new System.Drawing.Size(132, 83);
            this.btnykle.TabIndex = 1;
            this.btnykle.Text = "Bakiye Yükle";
            this.btnykle.UseVisualStyleBackColor = false;
            this.btnykle.Click += new System.EventHandler(this.btnykle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(69, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "YEMEK LİSTESİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_yemeklist);
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(167, 102);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(69, 13);
            this.lbl_bakiye.TabIndex = 4;
            this.lbl_bakiye.Text = "BAKİYENİZ=";
            // 
            // txt_bakiye
            // 
            this.txt_bakiye.Location = new System.Drawing.Point(272, 102);
            this.txt_bakiye.Name = "txt_bakiye";
            this.txt_bakiye.Size = new System.Drawing.Size(180, 20);
            this.txt_bakiye.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "KART_NO:";
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Location = new System.Drawing.Point(272, 496);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(176, 28);
            this.btnSifreDegistir.TabIndex = 9;
            this.btnSifreDegistir.Text = "Şifre değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = true;
            this.btnSifreDegistir.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtkartno
            // 
            this.txtkartno.AutoSize = true;
            this.txtkartno.Location = new System.Drawing.Point(143, 23);
            this.txtkartno.Name = "txtkartno";
            this.txtkartno.Size = new System.Drawing.Size(10, 13);
            this.txtkartno.TabIndex = 10;
            this.txtkartno.Text = "-";
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.White;
            this.btn_cikis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cikis.FlatAppearance.BorderSize = 3;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Location = new System.Drawing.Point(341, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(111, 31);
            this.btn_cikis.TabIndex = 11;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Müşteri_Bilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 532);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.txtkartno);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_bakiye);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnykle);
            this.Controls.Add(this.btngoruntule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Müşteri_Bilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri_Bilgileri";
            this.Load += new System.EventHandler(this.Müşteri_Bilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngoruntule;
        private System.Windows.Forms.Button btnykle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.TextBox txt_bakiye;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSifreDegistir;
        private System.Windows.Forms.Label txtkartno;
        private System.Windows.Forms.Button btn_cikis;
    }
}