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
    public partial class kullanicigirisekrani : Form
    {
        public RadioButton radioButton1;
        
        
        public List<Film> filmListesi;

        public kullanicigirisekrani(List<Film> FilmListesi)
        {
            InitializeComponent();
            filmListesi = FilmListesi;
           
            radioButton1 = radioButtonstandart;
        }
        

        private void Kontrol()
        {
            string kullaniciadi = kullaniciaditxt.Text;
            string sifre = sifretxt.Text;
            bool standart = radioButtonstandart.Checked;
            bool premium = radioButtonpremium.Checked;

            if(!standart && !premium)
            {
                MessageBox.Show("Lütfen kullanıcı türünü seçiniz.(Standart/premium)");
                return;
            }
            else
            {
                KullaniciEkrani kullaniciEkrani = new KullaniciEkrani(filmListesi);
                kullaniciEkrani.ShowDialog();

                

                if (kullaniciadi.Length == 0)
                {
                    MessageBox.Show("Lütfen kullanıcı adını giriniz.");
                }
                if (sifre.Length == 0)
                {
                    MessageBox.Show("Lütfen şifrenizi giriniz.");
                }
            }
            
        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            Kontrol();
        }

        private void radioButtonstandart_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
