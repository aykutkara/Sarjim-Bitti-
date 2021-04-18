
namespace GPProje
{
    partial class Nasil_oynanir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nasil_oynanir));
            this.nsloynanir_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aciklama_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nsloynanir_lbl
            // 
            this.nsloynanir_lbl.AutoSize = true;
            this.nsloynanir_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nsloynanir_lbl.Location = new System.Drawing.Point(31, 270);
            this.nsloynanir_lbl.Name = "nsloynanir_lbl";
            this.nsloynanir_lbl.Size = new System.Drawing.Size(147, 19);
            this.nsloynanir_lbl.TabIndex = 1;
            this.nsloynanir_lbl.Text = "NASIL OYNANIR ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // aciklama_lbl
            // 
            this.aciklama_lbl.AutoSize = true;
            this.aciklama_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aciklama_lbl.Location = new System.Drawing.Point(32, 305);
            this.aciklama_lbl.Name = "aciklama_lbl";
            this.aciklama_lbl.Size = new System.Drawing.Size(369, 16);
            this.aciklama_lbl.TabIndex = 3;
            this.aciklama_lbl.Text = "Oyunculardan istenilen katogorideki elimeleri bulmaları istenir.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "KAPAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nasil_oynanir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(643, 459);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aciklama_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nsloynanir_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Nasil_oynanir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NASIL OYNANIR ?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nsloynanir_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label aciklama_lbl;
        private System.Windows.Forms.Button button1;
    }
}