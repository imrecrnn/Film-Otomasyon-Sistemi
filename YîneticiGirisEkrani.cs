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
    public partial class YöneticiGirisEkrani : Form
    {
        public List<Film> filmListesi;
        public YöneticiGirisEkrani(List<Film> FilmListesi)
        {
            InitializeComponent();
            filmListesi = FilmListesi;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = yoneticikullaniciaditxt.Text;
            string sifre = yoneticisifretxt.Text;


            if (yoneticikullaniciaditxt.Text.Length == 0)
            {
                MessageBox.Show("Lütfen kullanıcı adını giriniz.");
                return;
            }
            if (yoneticisifretxt.Text.Length == 0)
            {
                MessageBox.Show("Lütfen şifrenizi giriin.");
                return;
            }

            if (yoneticikullaniciaditxt.Text == "admin" && yoneticisifretxt.Text == "admin")
            {
                YöneticiEkrani yöneticiEkrani = new YöneticiEkrani(filmListesi);
                yöneticiEkrani.ShowDialog();
                //   KullaniciEkrani kullaniciEkrani = new KullaniciEkrani(filmListesi);
                //kullaniciEkrani.ShowDialog();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                return;
            }
        }
    }
}
