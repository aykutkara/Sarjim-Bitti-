using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void nasil_oynanir_Click(object sender, EventArgs e)
        {
            Nasil_oynanir nasloynanir = new Nasil_oynanir();
            nasloynanir.Show();
            this.Hide();
        }

        private void oyuna_basla_Click(object sender, EventArgs e)
        {
            OyunEkrani basla = new OyunEkrani();
            basla.Show();
            basla.KelimeVeKategori();
            //this.Hide();

        }
    }
}
