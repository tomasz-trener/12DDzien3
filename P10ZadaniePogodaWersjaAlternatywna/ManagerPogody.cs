using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadaniePogodaWersjaAlternatywna
{
    internal class ManagerPogody
    {
        public Jednostka Jednostka = Jednostka.Celcjusz;
        public string url = "https://www.google.com/search?q=pogoda";
        private const char znak = '°'; // private warto pisac pomimo, ze jest domyslne 
        const char znakKoncowy = '>';

        public string PodajTemperature(string miasto)
        {
            // pobranie zawartosci strony z dynmanicznie generowanym adresem url
            
            string dane =
                 new WebClient().DownloadString($"{url} {miasto}");


            int indx = dane.IndexOf(znak);
            if (indx == -1)
            {
                //Console.WriteLine("Nieznane miasto");
                throw new Exception("Nieznane miasto");
            }

            int aktualnaPozycja = indx - 1;
            while (dane[aktualnaPozycja] != znakKoncowy)
                aktualnaPozycja--;

            int dlugosc = indx - aktualnaPozycja;
            if (dlugosc > 4)
            {
                //Console.WriteLine("Nieznane miasto");
                //return;
                throw new Exception("Nieznane miasto");
            }

            string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1-2); // usuwam znaki oC

            TransformatorJednostek tj = new TransformatorJednostek();
            wynik= Convert.ToString(tj.ZamienTemprature(Convert.ToInt32(wynik), Jednostka, Jednostka.Celcjusz));

            //Console.WriteLine(wynik);
            return wynik;
        }
    }
}
