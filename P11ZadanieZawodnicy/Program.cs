using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zawodnik z = new Zawodnik();
            z.Imie = "Jan";
            z.Nazwisko = "Kowalski";

            Zawodnik z1 = new Zawodnik()
            {
                Imie = "Adam",
                Nazwisko = "Nowak"
            };

            Console.WriteLine(z1.PrzedstawSie());


            string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string dane = new WebClient().DownloadString(sciezka);

             string[] wiersze=
                dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> bledneWiersze = new List<string>();
            List<Zawodnik> zawodnicy = new List<Zawodnik>();

           // Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length - 1];
            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki= wiersze[i].Split(';');

                try
                {
                    Zawodnik ityZawodnik = new Zawodnik();
                    ityZawodnik.Id = Convert.ToInt32(komorki[0]);
                    //if(!string.IsNullOrEmpty(komorki[1]))
                    ityZawodnik.Id_trenera = Convert.ToInt32(komorki[1]);

                    ityZawodnik.Imie = komorki[2];
                    ityZawodnik.Nazwisko = komorki[3];
                    ityZawodnik.Kraj = komorki[4];
                    ityZawodnik.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                    ityZawodnik.Wzrost = Convert.ToInt32(komorki[6]);
                    ityZawodnik.Waga = Convert.ToInt32(komorki[7]);

                    // zawodnicy[i - 1] = ityZawodnik; // i-1 bo przesuniecie o 1 wzgldem naglowka 
                    zawodnicy.Add(ityZawodnik);
                }
                catch (Exception)
                {
                    bledneWiersze.Add(wiersze[i]);
                }
                
            }

            foreach (var zw in zawodnicy)
                Console.WriteLine(zw.PrzedstawSie());

            Console.WriteLine("---- bledne wiersze -----");

            foreach (var b in bledneWiersze)
                Console.WriteLine(b);


            Console.ReadKey();
        }
    }
}
