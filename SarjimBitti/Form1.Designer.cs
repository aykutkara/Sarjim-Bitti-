
namespace SarjimBitti
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oyuna_basla = new System.Windows.Forms.Button();
            this.nasil_oynanir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // oyuna_basla
            // 
            this.oyuna_basla.BackColor = System.Drawing.Color.DarkOrange;
            this.oyuna_basla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oyuna_basla.Location = new System.Drawing.Point(114, 166);
            this.oyuna_basla.Name = "oyuna_basla";
            this.oyuna_basla.Size = new System.Drawing.Size(131, 31);
            this.oyuna_basla.TabIndex = 0;
            this.oyuna_basla.Text = "OYUNA BAŞLA";
            this.oyuna_basla.UseVisualStyleBackColor = false;
            this.oyuna_basla.Click += new System.EventHandler(this.oyuna_basla_Click);
            // 
            // nasil_oynanir
            // 
            this.nasil_oynanir.BackColor = System.Drawing.Color.DarkOrange;
            this.nasil_oynanir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nasil_oynanir.Location = new System.Drawing.Point(114, 249);
            this.nasil_oynanir.Name = "nasil_oynanir";
            this.nasil_oynanir.Size = new System.Drawing.Size(131, 31);
            this.nasil_oynanir.TabIndex = 1;
            this.nasil_oynanir.Text = "Nasıl Oynanır";
            this.nasil_oynanir.UseVisualStyleBackColor = false;
            this.nasil_oynanir.Click += new System.EventHandler(this.nasil_oynanir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SarjimBitti.Properties.Resources.arkpln;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 415);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(358, 414);
            this.Controls.Add(this.nasil_oynanir);
            this.Controls.Add(this.oyuna_basla);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞARJIM BİTTİ !!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oyuna_basla;
        private System.Windows.Forms.Button nasil_oynanir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

