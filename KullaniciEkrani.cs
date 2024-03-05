using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Nesne_DönemProjesi
{
    public partial class KullaniciEkrani : Form
    {
        //Nesne_DönemProjesi.Film yeniFilm = new Nesne_DönemProjesi.Film();
        public static List<Film> filmListesi;
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        public List<KullaniciBilgileri> kullanicilistesi;
        public List<İzlemeListem> izlemelistem;
        public RadioButton radioButton1;
        public KullaniciEkrani(List<Film> FilmListesi)
        {

            FilmDataSource.initializeFilmData();
            InitializeComponent();

            
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Yönetmen", typeof(string));
            tablo.Columns.Add("Oyuncular", typeof(string));
            tablo.Columns.Add("Tür", typeof(string));
            tablo.Columns.Add("Yayın yılı", typeof(int));
            tablo.Columns.Add("Değerlendirme Puanı", typeof(double));

            dataGridView1.DataSource = tablo;

            filmListesi =FilmListesi;
            filmListesi = FilmDataSource.filmler;

            tablo2.Columns.Add("Film Adı:", typeof(string));
            tablo2.Columns.Add("Değerlendirme Puanı", typeof(double));
            dataGridView2.DataSource = tablo2;
            
            tablo3.Columns.Add("Ad", typeof(string));
            tablo3.Columns.Add("Soyad", typeof(string));
            tablo3.Columns.Add("TC", typeof(string));
            tablo3.Columns.Add("Doğum Tarihi", typeof(string));
            tablo3.Columns.Add("Cinsiyet", typeof(int));
            tablo3.Columns.Add("Üyelik Türü", typeof(double));

            // Ardından, dataGridView3'e tablo3'ü bağlayın
            dataGridView3.DataSource = kullanicilistesi;
            

            foreach (var film in filmListesi)
            {
                listBox1.Items.Add(film.Ad);
            }

        }


        

        private void aramabtn_Click(object sender, EventArgs e)
        {
            string aramaKriteri = comboBox1.SelectedItem.ToString();
            string aramaKelimesi = textBox1.Text.ToLower();
            int i;



            // Burada List<Film> filtrelenmisFilmler değişkenini tanımlayın
            List<Film> filtrelenmisFilmler = new List<Film>();
            
            switch (aramaKriteri)
            {
                case "Ad'a göre":
                    filtrelenmisFilmler = filmListesi.Where(f => f.Ad.ToLower().Contains(aramaKelimesi)).ToList();
                    break;
                case "Yönetmene göre":
                    filtrelenmisFilmler = filmListesi.Where(f => f.Yonetmen.ToLower().Contains(aramaKelimesi)).ToList();
                    break;
                case "Türe göre":
                    filtrelenmisFilmler = filmListesi.Where(f => f.Tur.ToLower().Contains(aramaKelimesi)).ToList();
                    break;
            }
            //tablo.Rows.Clear();
            for (i = 0; i < filtrelenmisFilmler.Count; i++)
            {
                tablo.Rows.Add(filtrelenmisFilmler[i].Ad, filtrelenmisFilmler[i].Yonetmen, filtrelenmisFilmler[i].Oyuncular, filtrelenmisFilmler[i].Tur, filtrelenmisFilmler[i].YayinYili.ToString(), filtrelenmisFilmler[i].DegerlendirmePuani);
            }//


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablo;


        }
        
        public class degerlendirmePuani
        {
            public double degerlendirmepuani { get; set; }
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filmlerigoruntulebtn_Click(object sender, EventArgs e)
        {
            tablo2.Rows.Clear();

            // filmListesi'den gelen verileri degerlendirmelist'e aktar
            List<(string Ad, double DegerlendirmePuani)> degerlendirmelist = filmListesi.Select(film => (film.Ad, film.DegerlendirmePuani)).ToList();

            // degerlendirmelist'teki verileri DataGridView'e ekle
            foreach (var film in degerlendirmelist)
            {
                tablo2.Rows.Add(film.Ad, film.DegerlendirmePuani);
            }

            // DataGridView'i güncelle
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = tablo2;

            


        }

        private void degerlendirmeyapbtn_Click(object sender, EventArgs e)
        {
            kullanicigirisekrani kullanicigirisekrani = new kullanicigirisekrani(filmListesi);
            
            if (kullanicigirisekrani.radioButton1 != null && kullanicigirisekrani.radioButton1.Checked)
            {
                MessageBox.Show("Üyelik türünüz standart olduğu için değerlendirme yapma hakkınız yoktur!");
                return;
            }
            else
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    List<(string Ad, double DegerlendirmePuani)> degerlendirmelist = filmListesi.Select(film => (film.Ad, film.DegerlendirmePuani)).ToList();

                    int seciliIndex = dataGridView2.SelectedRows[0].Index;
                    Film secilifilm = filmListesi[seciliIndex];

                    secilifilm.DegerlendirmePuani = (secilifilm.DegerlendirmePuani + Convert.ToDouble(degpu.Text)) / 2;


                    MessageBox.Show("degerlendirme başarıyla güncellendi.");
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = tablo2;


                }
                else
                {
                    MessageBox.Show("Lütfen değerlendirilecek filmi seçin");
                }
            }


            
            


        }

        public class KullaniciBilgileri
        {
            public string kullaniciadi { get; set; }
            public string soyadi { get; set; }
            public string Tc { get; set; }
            public string DogumTarihi { get; set; }
            public string Cinsiyet { get; set; }
            public string kullaniciuyelik { get; set; }
            public KullaniciBilgileri(string kullaniciadi, string soyadi, string Tc, string DogumTarihi, string Cinsiyet,string kullaniciuyelik)
            {
                this.kullaniciadi = kullaniciadi;
                this.soyadi = soyadi;
                this.Tc = Tc;
                this.DogumTarihi = DogumTarihi;
                this.Cinsiyet = Cinsiyet;
                this.kullaniciuyelik = kullaniciuyelik;

            }
        }
        private void kullanicibilgieklebtn_Click(object sender, EventArgs e)
        {
            if (kullanicilistesi == null)
            {
                // Eğer null ise, yeni bir liste oluştur
                kullanicilistesi = new List<KullaniciBilgileri>();
            }
            KullaniciBilgileri yenikullanici = new KullaniciBilgileri(kullaniciadtxt.Text, soyadtxt.Text, tctxt.Text, dogumtarihitxt.Text, cinsiyettxt.Text, uyelikturutxt.Text);
            kullanicilistesi.Add(yenikullanici);

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = kullanicilistesi;

            MessageBox.Show("Bilgileriniz başarıyla eklendi");
        }

        private void kullanicibilgiguncellebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows[0] != null)
            {
                // İlk satır null değilse, burada yapılacak işlemleri gerçekleştir
                // Örneğin, ilk satırı seç
                dataGridView1.Rows[0].Selected = true;

                KullaniciBilgileri kullanicig = kullanicilistesi[0];
                kullanicig.kullaniciadi = kullaniciadtxt.Text;
                kullanicig.soyadi = soyadtxt.Text;
                kullanicig.Tc = tctxt.Text;
                kullanicig.DogumTarihi = dogumtarihitxt.Text;
                kullanicig.Cinsiyet = cinsiyettxt.Text;
                kullanicig.kullaniciuyelik = uyelikturutxt.Text;

                dataGridView3.DataSource = null;
                dataGridView3.DataSource = kullanicilistesi;

                MessageBox.Show("Güncelleme işlemi tamamlandi");
            }
        }

        private void hesabinikapatbtn_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("İşlemi tamamlamak istediğinizden emin misiniz?", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {                
                this.Close();
            }
            else
            {
                // Kullanıcı HAYIR'a tıkladı veya pencereyi kapattı, işlemi iptal et
                MessageBox.Show("İşlem iptal edildi.");
            }
        }

        public class İzlemeListem
        {
            public string Ad { get; set; }
            public string Yonetmen { get; set; }
            public string Oyuncular { get; set; }
            public string Tur { get; set; }
            public int YayinYili { get; set; }
            public double DegerlendirmePuani { get; set; }
            public İzlemeListem(string Ad, string Yonetmen, string Oyuncular, string Tur, int YayinYili, double DegerlendirmePuani)
            {
                this.Ad = Ad;
                this.Yonetmen = Yonetmen;
                this.Oyuncular = Oyuncular;
                this.Tur = Tur;
                this.YayinYili = YayinYili;
                this.DegerlendirmePuani = DegerlendirmePuani;
            }
        }
        DataTable tablo3 = new DataTable();
        private void artibtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int seciliIndex = dataGridView1.SelectedRows[0].Index;

                // Seçili satırı filmListesi'nden al
                Film seciliFilm = filmListesi[seciliIndex];

                // tablo3'e seçili satırın bilgilerini ekle
                tablo3.Rows.Add(seciliFilm.Ad, seciliFilm.Yonetmen, seciliFilm.Oyuncular, seciliFilm.Tur, seciliFilm.YayinYili, seciliFilm.DegerlendirmePuani);

                // tablo3'ü dataGridView3'e yeniden bağla
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = tablo3;
                MessageBox.Show("Film listenize eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen listenize eklemek için bir film seçin.");
            }
        }



        private void eksibtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int seciliIndex = dataGridView1.SelectedRows[0].Index;

                // tablo3'ten seçili satırı kaldır
                tablo3.Rows.RemoveAt(seciliIndex);

                // dataGridView3'ü güncelle
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = tablo3;
                MessageBox.Show("Film listenizden çıkarıldı");
            }
            else
            {
                MessageBox.Show("Lütfen listenizden çıkartmak istediğiniz filmi seçin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string secilenFilm = listBox1.SelectedItem?.ToString();
            string kullaniciGirdisi = richTextBox1.Text;

            // Her iki değerin de boş olup olmadığını kontrol et
            if (!string.IsNullOrEmpty(secilenFilm) && !string.IsNullOrEmpty(kullaniciGirdisi))
            {
                // Film ve değeri birleştirip ListBox'a ekleyerek görüntüle
                string yeniSatir = $"{secilenFilm}: {kullaniciGirdisi}";
                listBox1.Items.Add(yeniSatir);

                // TextBox'ı temizle
                richTextBox1.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen bir film seçin ve bir değer girin.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            FilmDataSource.initializeFilmData();
            filmListesi = FilmDataSource.filmler;
            dataGridView1.DataSource = filmListesi;
        }
    }
}
