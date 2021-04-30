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
    public partial class OyunEkrani : Form
    {
        public OyunEkrani()
        {
            InitializeComponent();

        }

        public static string str;
        public static char[] kelimeuzunlugu;
        public int sayac ;
        int pilcubugu = 6;
        public void KelimeVeKategori()
        {
            string[,] katagorivekelimeler = new string[3, 7]
            {
                { "ANKARA", "İSTANBUL", "İZMİR", "BURSA", "BALIKESİR", "CANAKKALE", "KONYA" ,} ,
                {"TÜRKİYE","ALMANYA","AMERİKA","İSPANYA","İTALYA","YUNANİSTAN","RUSYA" } ,
                { "FORD", "FIAT", "PEUGEOT", "MERCEDES", "VOLVO", "HONDA", "AUDI" }
            };

            Random rnd = new Random();
            Random rnd2 = new Random();
            int kelime = rnd.Next(0, 7);
            int kategori = rnd.Next(0, 3);
            lbl_kelime.Text = "";
            string secilenkelime ="";
            lbl_girilenharfler.Text = "";

            if (kategori == 0)
            {
                secilenkelime = katagorivekelimeler[0, kelime];
                MessageBox.Show(secilenkelime);

                lbl_kategori.Text = "Bu Bir Şehir";
                kelimeuzunlugu = new char[katagorivekelimeler[0, kelime].Length];
                sayac = kelimeuzunlugu.Length;

                for (int i = 0; i < kelimeuzunlugu.Length; i++)
                {
                    kelimeuzunlugu[i] = '_';

                }
                for (int i = 0; i < kelimeuzunlugu.Length; i++)
                {
                    lbl_kelime.Text += kelimeuzunlugu[i].ToString() + " ";
                }
                
            }
            else if (kategori == 1)
            {
                secilenkelime = katagorivekelimeler[1, kelime];
                MessageBox.Show(secilenkelime);

                lbl_kategori.Text = "Bu Bir Ülke";
                kelimeuzunlugu = new char[katagorivekelimeler[1, kelime].Length];
                sayac = kelimeuzunlugu.Length;

                for (int i = 0; i < kelimeuzunlugu.Length; i++)
                {
                    kelimeuzunlugu[i] = '_';

                }
                for (int i = 0; i < kelimeuzunlugu.Length; i++)
                {
                    lbl_kelime.Text += kelimeuzunlugu[i].ToString() + " ";
                }
                


            }
            else
            {
                secilenkelime = katagorivekelimeler[2, kelime];
                MessageBox.Show(secilenkelime);

                lbl_kategori.Text = "Bu Bir Araba Markası";
                kelimeuzunlugu = new char[katagorivekelimeler[2, kelime].Length];
                sayac = kelimeuzunlugu.Length;

                for (int i = 0; i < kelimeuzunlugu.Length; i++)
                {
                    kelimeuzunlugu[i] = '_';

                }
                for (int i = 0; i < kelimeuzunlugu.Length; i++)
                {
                    lbl_kelime.Text += kelimeuzunlugu[i].ToString() + " ";
                }
                

            }
            str = secilenkelime;
            
        }

        

        public void Islemler()
        {
            string secilenkelime = str;

            string girilentext = textBox1.Text.ToUpper();
            char girilenharf = Convert.ToChar(girilentext);
            lbl_girilenharfler.Text += girilentext;

            int a = 0;
            char[] girilenharfkontrol = new char[secilenkelime.Length];

            //for (int i = 0; i < 1; i++)
            //{

            //    girilenharfkontrol[a] = girilenharf;
            //    a++;
            //}
            //for (int i = 0; i < girilenharfkontrol.Length; i++)
            //{
            //    if (girilenharf == girilenharfkontrol[i])
            //    {
            //        MessageBox.Show("Bu harf girildi.");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            bool var_mi = false;

            for (int i = 0; i < secilenkelime.Length; i++)
            {
                if (girilenharf == secilenkelime[i])
                {
                    var_mi = true;
                    kelimeuzunlugu[i] = girilenharf;
                    //burda kaldım. burda kelimeuzunluğu[i] yi lblkelime ye eşitleyip _ ile yer değiştirmemiz lazım
                    lbl_kelime.Text = lbl_kelime.Text.Remove(i*2,1);
                    lbl_kelime.Text = lbl_kelime.Text.Insert(i * 2, girilenharf.ToString()).ToUpper();

                    sayac--;
                    
                    if (sayac == 0)
                    {
                        lbl_kelime.Text = secilenkelime;
                        MessageBox.Show(secilenkelime+ "\nOyunu Kazandınız.");
                        DialogResult secenek = MessageBox.Show("Tekrar Oynamak İstiyor musunuz ?", "Tebrikler", MessageBoxButtons.YesNo);
                        if (secenek == DialogResult.Yes)
                        {
                            sonraki_bolum();
                        }
                        else if (secenek == DialogResult.No)
                        {
                            this.Close();
                        }
                       
                    }
                }
            }
            
            if (!var_mi)
            {
                pilcubugu--;
                switch (pilcubugu)
                {
                    case 1:
                        pcb_pil.ImageLocation = @"resimler\bos_pil.jpg";
                        MessageBox.Show("Cevap : " + secilenkelime + "\nOyunu Kaybettin!");
                        this.Close();
                        
                        break;
                    case 2:
                        pcb_pil.ImageLocation = @"resimler\2_pil.jpg";
                        break;
                    case 3:
                        pcb_pil.ImageLocation = @"resimler\3_pil.jpg";
                        break;
                    case 4:
                        pcb_pil.ImageLocation = @"resimler\4_pil.jpg";
                        break;
                    case 5:
                        pcb_pil.ImageLocation = @"resimler\5_pil.jpg";
                        break;
                }
            }
        }
        private void sonraki_bolum()
        {
            Temizle();
            KelimeVeKategori();
        }
        private void Temizle()
        {
            pcb_pil.ImageLocation = @"resimler\ful_pil.jpg";
            pilcubugu = 6;
            lbl_kategori.Text = "";
            lbl_kelime.Text = "";
            lbl_girilenharfler.Text = "";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcb_pil_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//burayı girilecek değerin sadece harf olması için oluşturduk.
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '+' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_harfgir_Click(sender, e);
            }
        }
        private void btn_harfgir_Click(object sender, EventArgs e)
        {

            Islemler();
            textBox1.Clear();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void OyunEkrani_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
