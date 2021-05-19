
namespace GPProje
{
    partial class OyunEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunEkrani));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pcb_pil = new System.Windows.Forms.PictureBox();
            this.btn_harfgir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_girilenharfler = new System.Windows.Forms.Label();
            this.lbl_kelime = new System.Windows.Forms.Label();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_pil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.pcb_pil);
            this.panel1.Controls.Add(this.btn_harfgir);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbl_girilenharfler);
            this.panel1.Controls.Add(this.lbl_kelime);
            this.panel1.Controls.Add(this.lbl_kategori);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 471);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1.Location = new System.Drawing.Point(22, 243);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(118, 20);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Girilen Harfler : ";
            // 
            // pcb_pil
            // 
            this.pcb_pil.Image = ((System.Drawing.Image)(resources.GetObject("pcb_pil.Image")));
            this.pcb_pil.Location = new System.Drawing.Point(301, 12);
            this.pcb_pil.Name = "pcb_pil";
            this.pcb_pil.Size = new System.Drawing.Size(252, 448);
            this.pcb_pil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_pil.TabIndex = 0;
            this.pcb_pil.TabStop = false;
            this.pcb_pil.Click += new System.EventHandler(this.pcb_pil_Click);
            // 
            // btn_harfgir
            // 
            this.btn_harfgir.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_harfgir.Location = new System.Drawing.Point(150, 167);
            this.btn_harfgir.Name = "btn_harfgir";
            this.btn_harfgir.Size = new System.Drawing.Size(109, 26);
            this.btn_harfgir.TabIndex = 11;
            this.btn_harfgir.Text = "Harf Gir";
            this.btn_harfgir.UseVisualStyleBackColor = false;
            this.btn_harfgir.Click += new System.EventHandler(this.btn_harfgir_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(25, 167);
            this.textBox1.MaxLength = 1;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_girilenharfler
            // 
            this.lbl_girilenharfler.AutoSize = true;
            this.lbl_girilenharfler.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_girilenharfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_girilenharfler.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_girilenharfler.Location = new System.Drawing.Point(23, 274);
            this.lbl_girilenharfler.Name = "lbl_girilenharfler";
            this.lbl_girilenharfler.Size = new System.Drawing.Size(57, 15);
            this.lbl_girilenharfler.TabIndex = 9;
            this.lbl_girilenharfler.Text = "Girilenler";
            // 
            // lbl_kelime
            // 
            this.lbl_kelime.AutoSize = true;
            this.lbl_kelime.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_kelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kelime.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_kelime.Location = new System.Drawing.Point(22, 84);
            this.lbl_kelime.Name = "lbl_kelime";
            this.lbl_kelime.Size = new System.Drawing.Size(56, 20);
            this.lbl_kelime.TabIndex = 8;
            this.lbl_kelime.Text = "Kelime";
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kategori.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_kategori.Location = new System.Drawing.Point(22, 40);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(79, 24);
            this.lbl_kategori.TabIndex = 7;
            this.lbl_kategori.Text = "Kategori";
            // 
            // OyunEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(565, 472);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OyunEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şarjım Bitti !!";
            this.Load += new System.EventHandler(this.OyunEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_pil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.Label lbl_kelime;
        private System.Windows.Forms.Label lbl_girilenharfler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_harfgir;
        private System.Windows.Forms.PictureBox pcb_pil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1;
    }
}