using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarjimBitti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Bu buton metodunu oyunun mantığını bilmeyen biri oyuna girdiği zaman 
        /// nasıl oynayacağını öğrenmesi için "Nasil_oynanir" formunu açmak için oluşturduk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nasil_oynanir_Click(object sender, EventArgs e)
        {
            Nasil_oynanir nasloynanir = new Nasil_oynanir();
            nasloynanir.Show();
            this.Hide();
        }

        /// <summary>
        /// Bu metodu butona basınca oyun başlasın ve "OyunEkrani" formuna geçsin diye oluşturduk.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oyuna_basla_Click(object sender, EventArgs e)
        {
            OyunEkrani basla = new OyunEkrani();
            basla.Show();
            basla.KelimeVeKategori(); //bu satırı butona tıklayınca direkt oyun başlayacağı için katagori ve kelimeyi seçsin diye yazdık.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
