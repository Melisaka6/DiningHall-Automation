
namespace Yemekhane_Kayıt_Programı
{
    partial class Yemek_Listesi
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
            this.btnfiyat = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_goster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfiyat
            // 
            this.btnfiyat.BackColor = System.Drawing.Color.White;
            this.btnfiyat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnfiyat.FlatAppearance.BorderSize = 2;
            this.btnfiyat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnfiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiyat.Location = new System.Drawing.Point(179, 284);
            this.btnfiyat.Name = "btnfiyat";
            this.btnfiyat.Size = new System.Drawing.Size(101, 69);
            this.btnfiyat.TabIndex = 1;
            this.btnfiyat.Text = "Fiyat Listesi";
            this.btnfiyat.UseVisualStyleBackColor = false;
            this.btnfiyat.Click += new System.EventHandler(this.btnfiyat_Click);
            // 
            // btngeri
            // 
            this.btngeri.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btngeri.FlatAppearance.BorderSize = 3;
            this.btngeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.Location = new System.Drawing.Point(3, 336);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(53, 26);
            this.btngeri.TabIndex = 2;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(256, 179);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_goster
            // 
            this.btn_goster.BackColor = System.Drawing.Color.White;
            this.btn_goster.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btn_goster.FlatAppearance.BorderSize = 2;
            this.btn_goster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_goster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goster.Location = new System.Drawing.Point(97, 228);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(78, 29);
            this.btn_goster.TabIndex = 5;
            this.btn_goster.Text = "Göster";
            this.btn_goster.UseVisualStyleBackColor = false;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // Yemek_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 365);
            this.Controls.Add(this.btn_goster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnfiyat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Yemek_Listesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemek_Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnfiyat;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_goster;
    }
}