namespace Nesne_DönemProjesi
{
    public class Film
    {
        public string Ad { get; set; }
        public string Yonetmen { get; set; }
        public string Oyuncular { get; set; }
        public string Tur { get; set; }
        public int YayinYili { get; set; }
        public double DegerlendirmePuani { get; set; }
        public Film(string Ad, string Yonetmen, string Oyuncular, string Tur, int YayinYili, double DegerlendirmePuani)
        {
            this.Ad = Ad;
            this.Yonetmen = Yonetmen;
            this.Oyuncular = Oyuncular;
            this.Tur = Tur;
            this.YayinYili = YayinYili;
            this.DegerlendirmePuani = DegerlendirmePuani;


        }
        
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}