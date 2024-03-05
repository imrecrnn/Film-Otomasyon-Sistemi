using System;
using System.Windows.Forms;


namespace Nesne_DönemProjesi
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();    
        }
       
        public List<Film> FilmListesi = new List<Film>();
        
        
        private void kullanicigirisibtn_Click(object sender, EventArgs e)
        {
            kullanicigirisekrani kullanicigirisekrani = new kullanicigirisekrani(FilmListesi);

            kullanicigirisekrani.ShowDialog();
        }

        private void yoneticigirisibtn_Click(object sender, EventArgs e)
        {
            YöneticiGirisEkrani yöneticiGirisEkrani = new YöneticiGirisEkrani(FilmListesi);
            yöneticiGirisEkrani.ShowDialog();
        }
        
    }
    
}