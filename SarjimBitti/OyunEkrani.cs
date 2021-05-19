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
    public partial class OyunEkrani : Form
    {
        public OyunEkrani()
        {
            InitializeComponent();

        }

        public static string str; //bu değişkeni, "KelimeVeKatagori" metodundaki "secilenkelime" değişkenini "Islemler" metoduna taşıyabilmek için oluşturduk.
        public static char[] kelimeuzunlugu;//bu char dizisini,secilen kelimenin uzunluğu kadar label da "_" koymak için oluşturduk.
        public int sayac;//bu değişkeni, "kelimeuzunluğu" değişkeninin uzunluğuna eşitleyip kullanıcı her bildiğinde azaltıp oyunu kazanıp kazanmadığını kontrol etmek için oluşturduk.
        int pilcubugu = 6;//bu değişkeni, kullanıcı her yanlış tahmin yaptığında pil görselindeki çubuğu azaltmak için oluşturduk.

        /// <summary>
        /// Bu metodu, oyun başladığında veya tekrar oynanmak istediğinde kategori ve kelimenin belirlenmesi için oluşturduk.
        /// </summary>
        public void KelimeVeKategori()
        {
            string[,] katagorivekelimeler = new string[3, 7] //bu dizide, katagori ve kelimeleri belirledik.(0-7 arası şehirler, 1-7 arası ülkeler, 2-7 arası araba markaları)
            {
                { "ANKARA", "İSTANBUL", "İZMİR", "BURSA", "BALIKESİR", "CANAKKALE", "KONYA" ,} ,
                {"TÜRKİYE","ALMANYA","AMERİKA","İSPANYA","İTALYA","YUNANİSTAN","RUSYA" } ,
                { "FORD", "FIAT", "PEUGEOT", "MERCEDES", "VOLVO", "HONDA", "AUDI" }
            };

            Random rnd = new Random(); // Random sınıfındaki bu örneği kelime ve katagoriyi rastgele seçmek için oluşturduk.
            int kelime = rnd.Next(0, 7); //bu değişkeni, rastgele seçilecek olan kelimenin dizinin kaçıncı elemanı olacağını belirlemek için oluşturduk.
            int kategori = rnd.Next(0, 3);//bu değişkeni, rastgele seçilecek olan katagorinin dizinin kaçıncı elemanı olacağını belirlemek için oluşturduk.
            lbl_kelime.Text = "";//metodu çağırdığımızda "lbl_kelime" nin textinde hiç bişey yazmasın diye yazdık.
            string secilenkelime = "";//bu değişkeni, random olarak seçilecek kelimeye atamak için oluşturduk.
            lbl_girilenharfler.Text = "";//metodu çağırdığımızda "lbl_girilenharfler" in textinde hiç bişey yazmasın diye yazdık.

            if (kategori == 0)//random olarak seçilen sayıya göre katagoriyi belirlemek için oluşturduk(0 ise şehir , 1 ise ülke , 2 ise araba markası)
            {
                secilenkelime = katagorivekelimeler[kategori, kelime];//"secilenkelime" değişkenini random olarak ayarladığımız "kategori" ve "kelime" değerlerininden yararlanarak "katagorivekelimeler" dizisindeki değere atıyoruz.
                lbl_kategori.Text = "Bu Bir Şehir";//bu if bloğuna girdiği için ""lbl_kategori" nin textini değiştiriyoruz.
                kelimeuzunlugu = new char[katagorivekelimeler[kategori, kelime].Length];//"kelimeuzunlugu" dizisinin boyutunu seçilen kelimenin uzunluğuna eşitliyoruz.
                sayac = kelimeuzunlugu.Length;

                for (int i = 0; i < kelimeuzunlugu.Length; i++)//bu döngüyü,kelimenin harflerini "_" ye çevirmek için oluşturduk.
                {
                    kelimeuzunlugu[i] = '_';

                }
                for (int i = 0; i < kelimeuzunlugu.Length; i++)//bu döngüyü,  label da kelimenin harfleri görünmesin onun yerine kelimenin harf sayısı kadar "_" yazdıralım diye oluşturduk.
                {
                    lbl_kelime.Text += kelimeuzunlugu[i].ToString() + " ";
                }

            }
            else if (kategori == 1)//random olarak seçilen sayıya göre katagoriyi belirlemek için oluşturduk(0 ise şehir , 1 ise ülke , 2 ise araba markası)
            {
                secilenkelime = katagorivekelimeler[kategori, kelime];//"secilenkelime" değişkenini random olarak ayarladığımız "kategori" ve "kelime" değerlerininden yararlanarak "katagorivekelimeler" dizisindeki değere atıyoruz.
                lbl_kategori.Text = "Bu Bir Ülke";//bu else if bloğuna girdiği için ""lbl_kategori" nin textini değiştiriyoruz.
                kelimeuzunlugu = new char[katagorivekelimeler[kategori, kelime].Length];//"kelimeuzunlugu" dizisinin boyutunu seçilen kelimenin uzunluğuna eşitliyoruz.
                sayac = kelimeuzunlugu.Length;

                for (int i = 0; i < kelimeuzunlugu.Length; i++)//bu döngüyü,kelimenin harflerini "_" ye çevirmek için oluşturduk.
                {
                    kelimeuzunlugu[i] = '_';

                }
                for (int i = 0; i < kelimeuzunlugu.Length; i++)//bu döngüyü,  label da kelimenin harfleri görünmesin onun yerine kelimenin harf sayısı kadar "_" yazdıralım diye oluşturduk.
                {
                    lbl_kelime.Text += kelimeuzunlugu[i].ToString() + " ";
                }
            }
            else //random olarak seçilen sayıya göre katagoriyi belirlemek için oluşturduk(0 ise şehir , 1 ise ülke , 2 ise araba markası)
            {
                secilenkelime = katagorivekelimeler[kategori, kelime];//"secilenkelime" değişkenini random olarak ayarladığımız "kategori" ve "kelime" değerlerininden yararlanarak "katagorivekelimeler" dizisindeki değere atıyoruz.
                lbl_kategori.Text = "Bu Bir Araba Markası";//bu else bloğuna girdiği için ""lbl_kategori" nin textini değiştiriyoruz.
                kelimeuzunlugu = new char[katagorivekelimeler[kategori, kelime].Length];//"kelimeuzunlugu" dizisinin boyutunu seçilen kelimenin uzunluğuna eşitliyoruz.
                sayac = kelimeuzunlugu.Length;

                for (int i = 0; i < kelimeuzunlugu.Length; i++)//bu döngüyü,kelimenin harflerini "_" ye çevirmek için oluşturduk.
                {
                    kelimeuzunlugu[i] = '_';

                }
                for (int i = 0; i < kelimeuzunlugu.Length; i++)//bu döngüyü, label da kelimenin harfleri görünmesin onun yerine kelimenin harf sayısı kadar "_" yazdıralım diye oluşturduk.
                {
                    lbl_kelime.Text += kelimeuzunlugu[i].ToString() + " ";
                }
            }
            str = secilenkelime;//secilenkelime yi "Islemler" metodunda kullanmak için str ye eşitledik.
        }

        /// <summary>
        /// Bu metodu, oyuncu buton a bastıktan sonra gerçekleşmesi gerekli işlemler ve kontrollerin yapılması için oluşturduk.
        /// </summary>
        public void Islemler()
        {

            string secilenKelime = str;//bu değişkeni, "KelimeVeKategori" metodunda belirlenen kelimeyi "Islemler" metodunda da kullanmak için oluşturduk.
            string girilentext = textBox1.Text.ToUpper();//bu değişkeni, textbox a girilen harfi kullanmak ve kontrol etmek için oluşturduk.
            char girilenharf = ' ';//bu değişkeni,girilen harfin seçilen kelimenin harflerinden biri mi diye kontrol etmek için oluşturduk.
            if (girilentext == "")//textbox ın boş bırakılmaması için oluşturduk.
            {
                MessageBox.Show("Boş bırakılamaz." + "\nLütfen bir harf giriniz.");
                return;

            }
            else//textbox boş değilse gerçekleşmesi gerken işlemler için oluşturduk.
            {
                foreach (var item in lbl_girilenharfler.Text)//bu döngü, girilen bütün harfleri char olarak döndürsün diye oluşturduk.
                {
                    if (item.ToString() == girilentext)//yeni girilen metin foreach döngüsü yardımıyla daha önce girilmiş mi kontrol etsin diye oluşturduk.
                    {
                        MessageBox.Show("Bu harfi daha önce girdiniz.");
                        return;
                    }
                }
                girilenharf = Convert.ToChar(girilentext);
                lbl_girilenharfler.Text += girilentext;//oyuncu daha önce hangi harfleri girdiğini görsün diye oluşturduk.
            }

            bool var_mi = false;//pil görselini duruma göre değiştirmek için oluşturduk.

            for (int i = 0; i < secilenKelime.Length; i++)//bu döngüyü, girilen harfin seçilen kelimenin harflerinden biriyle uyuşuyor mu diye oluşturduk.
            {
                if (girilenharf == secilenKelime[i])//girilen harf var mı diye kontrol ediyoruz.
                {
                    var_mi = true;//girilen harf olduğu için aşşağıdaki tekrardan if bloğuna girip resmi değiştirmemesi için true yaptık.
                    kelimeuzunlugu[i] = girilenharf;//girilen harf kelimede bulunduğu için "kelimeuzunluğu" değişkeninin o an ki i. değerini "_" yerine girilen harfe eşitledik.
                    lbl_kelime.Text = lbl_kelime.Text.Remove(i * 2, 1);//formdaki label dan "_" yi sildik.
                    lbl_kelime.Text = lbl_kelime.Text.Insert(i * 2, girilenharf.ToString()).ToUpper();//formdaki label ın sildiğimiz yerine girilen harfi yazdırdık. 
                    sayac--; //kullanıcı her bildiğinde sayacı azaltıyoruz ki kaç tane bilmesi gereken harf kaldı belli olsun.
                    if (sayac == 0)//sayac sıfırlanınca bilmediği hiç harf kalmadığı için oyunu kazanmış oluyor.
                    {
                        lbl_kelime.Text = secilenKelime;//bütün kelimeeleri bilince formda ki label da secilen kelimeyi yazdırıyoruz.
                        MessageBox.Show("Cevap : " + secilenKelime + "\nOYUNU KAZANDINIZ.", "Tebrikler");
                        DialogResult secenek = MessageBox.Show("Tekrar Oynamak İstiyor musunuz ?", "Tebrikler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//oyuncuya tekrar oynamak isteyip istemediğini soruyoruz.
                        if (secenek == DialogResult.Yes)//evet i seçerse sonraki_bolum metodunu çağırarak oyunu sıfırlayıp yeni oyuna geçiyor.
                        {
                            sonraki_bolum();
                        }
                        else if (secenek == DialogResult.No)//hayır ı seçerse form u kapatıyoruz.
                        {
                            this.Close();
                        }
                    }
                }
            }
            if (!var_mi) // eğer textbox a girdiği değer secilen kelimenin harflerinden biri değilse buraya giriyor ve görselden pil çubuğu eksiliyor.
            {
                pilcubugu--;//bu if bloğuna her girdiğinde tekrardan yanlış tahmin ettiği için pilçubugu nu azaltıyoruz ki ona göre görsel koyalım.
                switch (pilcubugu)//bu switch-case bloklarında pilcubugu değerlerine göre ekrana görselleri getiriyoruz.
                {
                    case 1: //bu durumda hiç hakkı kalmadığı için oyunu kaybediyor ve form u kapatıyoruz.
                        pcb_pil.ImageLocation = @"resimler\bos_pil.jpg";
                        MessageBox.Show("Cevap : " + secilenKelime + "\nOyunu Kaybettin!");
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

        /// <summary>
        /// Bu metodu, oyuncu kelimeyi bildiği zaman formdaki değerler sıfırlansın ve yeni kelime gelsin diye oluşturduk.
        /// </summary>
        private void sonraki_bolum()
        {
            Temizle();
            KelimeVeKategori();
        }

        /// <summary>
        /// Bu metodu, oyunu kazanıp bir sonraki bölüme geçerken veya kaybettiğinde görsel,çubuk değeri,lbl textleri,textbox texti sıfırlansın diye oluşturduk.
        /// </summary>
        private void Temizle()
        {
            pcb_pil.ImageLocation = @"resimler\ful_pil.jpg";
            pilcubugu = 6;
            lbl_kategori.Text = "";
            lbl_kelime.Text = "";
            lbl_girilenharfler.Text = "";
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//bu metodu girilecek değerin sadece harf olması için oluşturduk.
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '+' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)//bu metodu klavyeden enter a basınca otomatik olarak buton a basması için oluşturduk.
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_harfgir_Click(sender, e);
            }
        }
        private void btn_harfgir_Click(object sender, EventArgs e)
        {

            Islemler();
            textBox1.Clear();//Butona bastıktan sonra kullanıcı yeni harf gireceği zaman her seferinde önce girdiğini silip yeniden yazmasın diye her tıklamaya textbox ın içindeki text i silmek için yazdık.

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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcb_pil_Click(object sender, EventArgs e)
        {

        }
    }

}
