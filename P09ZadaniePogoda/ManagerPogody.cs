using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadaniePogoda
{
    internal class ManagerPogody
    {
        public string PodajTemperature(string miasto)
        {
            const string url = "https://www.google.com/search?q=pogoda";
            const char znak = '°';
            const char znakKoncowy = '>';

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

            string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);

            //Console.WriteLine(wynik);
            return wynik;
        }
    }
}
