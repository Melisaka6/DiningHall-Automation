
namespace Yemekhane_Kayıt_Programı.form
{
    partial class FiyatListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiyatListesi));
            this.chc_ogretmen = new System.Windows.Forms.CheckBox();
            this.chc_ogrenci = new System.Windows.Forms.CheckBox();
            this.chcıdarı = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtogretmen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chc_ogretmen
            // 
            this.chc_ogretmen.AutoSize = true;
            this.chc_ogretmen.Location = new System.Drawing.Point(6, 19);
            this.chc_ogretmen.Name = "chc_ogretmen";
            this.chc_ogretmen.Size = new System.Drawing.Size(72, 17);
            this.chc_ogretmen.TabIndex = 0;
            this.chc_ogretmen.Text = "Öğretmen";
            this.chc_ogretmen.UseVisualStyleBackColor = true;
            this.chc_ogretmen.CheckedChanged += new System.EventHandler(this.chc_ogretmen_CheckedChanged);
            // 
            // chc_ogrenci
            // 
            this.chc_ogrenci.AutoSize = true;
            this.chc_ogrenci.Location = new System.Drawing.Point(6, 73);
            this.chc_ogrenci.Name = "chc_ogrenci";
            this.chc_ogrenci.Size = new System.Drawing.Size(63, 17);
            this.chc_ogrenci.TabIndex = 1;
            this.chc_ogrenci.Text = "Öğrenci";
            this.chc_ogrenci.UseVisualStyleBackColor = true;
            this.chc_ogrenci.CheckedChanged += new System.EventHandler(this.chc_ogrenci_CheckedChanged);
            // 
            // chcıdarı
            // 
            this.chcıdarı.AutoSize = true;
            this.chcıdarı.Location = new System.Drawing.Point(6, 119);
            this.chcıdarı.Name = "chcıdarı";
            this.chcıdarı.Size = new System.Drawing.Size(90, 17);
            this.chcıdarı.TabIndex = 2;
            this.chcıdarı.Text = "İdari Personel";
            this.chcıdarı.UseVisualStyleBackColor = true;
            this.chcıdarı.CheckedChanged += new System.EventHandler(this.chcıdarı_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chcıdarı);
            this.groupBox1.Controls.Add(this.chc_ogrenci);
            this.groupBox1.Controls.Add(this.chc_ogretmen);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtogretmen
            // 
            this.txtogretmen.Location = new System.Drawing.Point(64, 218);
            this.txtogretmen.Name = "txtogretmen";
            this.txtogretmen.Size = new System.Drawing.Size(114, 20);
            this.txtogretmen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lütfen Fiyat Listesi için bir seçim yapınız.";
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.White;
            this.btngeri.ImageKey = "340.png";
            this.btngeri.ImageList = this.ımageList1;
            this.btngeri.Location = new System.Drawing.Point(12, 227);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(30, 23);
            this.btngeri.TabIndex = 7;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "340.png");
            // 
            // FiyatListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 262);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtogretmen);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FiyatListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiyatListesi";
            this.Load += new System.EventHandler(this.FiyatListesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chc_ogretmen;
        private System.Windows.Forms.CheckBox chc_ogrenci;
        private System.Windows.Forms.CheckBox chcıdarı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtogretmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.ImageList ımageList1;
    }
}