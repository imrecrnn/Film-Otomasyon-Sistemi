using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_DönemProjesi
{

    public partial class YöneticiEkrani : Form
    {
        //Nesne_DönemProjesi.Film yeniFilm = new Nesne_DönemProjesi.Film();
        public List<Film> filmListesi;
        

        public YöneticiEkrani(List<Film> FilmListesi)
        {
            InitializeComponent();

            //dataGridView1.DataSource = VeriPaylasim.FilmListesi;
            filmListesi = FilmListesi;
    

        }



        public void ShowTabControl()
        {
            tabControl1.Visible = true;

            // Örneğin: tabControl1.SelectedTab = tabPage2;
        }

        private void filmeklebtn_Click(object sender, EventArgs e)
        {

            Film yeniFilm = new Film(filmaditxt.Text, yonetmentxt.Text, oyunculartxt.Text, filmturutxt.Text, Convert.ToInt32(yayinyilitxt.Text), Convert.ToInt32(degerlendirmepuanitxt.Text));


            filmListesi.Add(yeniFilm);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filmListesi;


            notifyIcon1.Icon = SystemIcons.Warning;
            notifyIcon1.Text = "Uygulama Adı";
            notifyIcon1.ShowBalloonTip(800);
        }



        DataTable tablo = new DataTable();
        private void YöneticiEkrani2_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Yönetmen", typeof(string));
            tablo.Columns.Add("Oyuncular", typeof(string));
            tablo.Columns.Add("Tür", typeof(string));
            tablo.Columns.Add("Yayın yılı", typeof(int));
            tablo.Columns.Add("Değerlendirme Puanı", typeof(int));

            dataGridView1.DataSource = tablo;

        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // En az bir satır seçilmişse devam et
            {
                int seciliIndex = dataGridView1.SelectedRows[0].Index; // Seçili satırın index'ini al

                // Seçili satırdaki filmi al
                Film seciliFilm = filmListesi[seciliIndex];

                // Yeni bilgileri kullanarak filmi güncelle
                seciliFilm.Ad = filmaditxt.Text;
                seciliFilm.Yonetmen = yonetmentxt.Text;
                seciliFilm.Oyuncular = oyunculartxt.Text;
                seciliFilm.Tur = filmturutxt.Text;
                seciliFilm.YayinYili = Convert.ToInt32(yayinyilitxt.Text);
                seciliFilm.DegerlendirmePuani = Convert.ToInt32(degerlendirmepuanitxt.Text);

                // DataGridView'i güncellenmiş film listesi ile tekrar doldur
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filmListesi;

                MessageBox.Show("Film başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir film seçin.");
            }
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            FilmDataSource.initializeFilmData();
            filmListesi = FilmDataSource.filmler;
            dataGridView1.DataSource = filmListesi;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        
        private bool isButtonClicked = false;
        
        private void EnYuksekPuanliFilmleriGoster()
        {
            dataGridView1.DataSource = filmListesi;

            
            filmListesi = filmListesi.OrderByDescending(film => film.DegerlendirmePuani).ToList();

            
            dataGridView2.DataSource = null;

            
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = filmListesi.Select(film => new { film.Ad, film.DegerlendirmePuani }).ToList();
        }
        private void raporalbtn_Click(object sender, EventArgs e)
        {
            EnYuksekPuanliFilmleriGoster();

            if (!isButtonClicked)
            {
                listBox1.Items.Clear();

                
                var sıralıTürler = filmListesi
                    .GroupBy(film => film.Tur)
                    .Select(grp => new { Tur = grp.Key, Sayi = grp.Count() })
                    .OrderByDescending(x => x.Sayi);

                foreach (var tür in sıralıTürler)
                {
                    listBox1.Items.Add(tür.Tur + ": " + tür.Sayi);
                }

                
                isButtonClicked = true;
            }



        }
        }
    }

/*filmListesi.Sort((f1, f2) => f2.DegerlendirmePuani.CompareTo(f1.DegerlendirmePuani));

            // DataGridView'i temizle
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filmListesi;

            // Puanı En Yüksek Filmler Listesini DataGridView'e ekle
            foreach (Film film in filmListesi)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                row.Cells[0].Value = film.Ad;
                row.Cells[1].Value = film.Yonetmen;
                row.Cells[2].Value = film.Tur;
                row.Cells[3].Value = film.YayinYili;
                row.Cells[4].Value = film.DegerlendirmePuani;
                row.Cells[5].Value = film.Oyuncular;

                dataGridView1.Rows.Add(row);
            }

            if (!isButtonClicked)
            {
                // En çok değerlendirilen türleri listeye ekle
                Dictionary<string, int> türler = new Dictionary<string, int>();

                foreach (Film film in filmListesi)
                {
                    if (!türler.ContainsKey(film.Tur))
                    {
                        türler.Add(film.Tur, 0);
                    }

                    türler[film.Tur]++;
                }

                // Listbox'ı temizle
                listBox1.Items.Clear();

                // Türleri değerlendirme sayısına göre sırala ve Listbox'a ekle
                foreach (var tür in türler.OrderByDescending(p => p.Value))
                {
                    listBox1.Items.Add(tür.Key + ": " + tür.Value);
                }

                // Set the flag to true to indicate that the button has been clicked
                isButtonClicked = true;
*/
/*filmListesi = filmListesi.OrderByDescending(film => film.DegerlendirmePuani).ToList();

            // DataGridView2'yi temizle
            dataGridView2.DataSource = null;

            // Sıralanmış filmleri DataGridView2'ye ekle
            dataGridView2.DataSource = filmListesi;*/
