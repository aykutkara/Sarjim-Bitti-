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
    public partial class Nasil_oynanir : Form
    {
        public Nasil_oynanir()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Bu buton metodunu "Nasil_oynanir"formunu kapatıp ana forma(Form1) dönmek için oluşturduk.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }
    }
}
