using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_DönemProjesi
{
    internal class FilmDataSource
    {
     public  static  List<Film> filmler=new List<Film>();
    public static void initializeFilmData()
        {
            // Filmleri oluşturup listeye ekleme
            filmler.Add(new Film("The Shawshank Redemption", "Frank Darabont","Tim Robbins-Morgan Freeman", "Dram", Convert.ToInt32(2023), 9.3));
            filmler.Add(new Film("La La Land", "Damien Chazelle", "Ryan Gosling-Emma Stone" , "Dram, Müzikal, Romantik", Convert.ToInt16(2023), 8.0));
            filmler.Add(new Film("Inception", "Christopher Nolan", "Leonardo DiCaprio-Joseph Gordon-Levitt-Ellen Page", "Bilim Kurgu- Aksiyon", Convert.ToInt32(2023), 8.8));
            filmler.Add(new Film("The Dark Knight", "Christopher Nolan", "Christian Bale-Heath Ledger-Aaron Eckhart", "Aksiyon-Suç- Dram", 2008, 9.0));
            filmler.Add(new Film("Pulp Fiction", "Quentin Tarantino", "John Travolta- Uma Thurman-Samuel L. Jackson" , "Suç- Dram", Convert.ToInt32(2023), 8.9));
            filmler.Add(new Film("The Grand Budapest Hotel", "Wes Anderson", "Ralph Fiennes-Tony Revolori-Saoirse Ronan" , "Komedi, Macera", Convert.ToInt32(2023), 8.1));


        }
    }
}
