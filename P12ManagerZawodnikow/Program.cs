using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12ManagerZawodnikow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt"; 
            ManagerZawodnikow mz = new ManagerZawodnikow(sciezka);
          //  mz.Sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
          
            

            Zawodnik[] zawodnicy= mz.WczytajZawodnikow();
            List<string> bledne= mz.BledneWiersze;

            

            //ManagerZawodnikow mz2 = new ManagerZawodnikow();
            //Zawodnik[] zawodnicy2 = mz2.WczytajZawodnikow();

            foreach (var z in zawodnicy)
                Console.WriteLine(z.PrzedstawSie());

        
        }
    }
}
