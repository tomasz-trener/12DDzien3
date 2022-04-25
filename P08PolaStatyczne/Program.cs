using P08PolaStatyczne.Narzedzia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08PolaStatyczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c1 = new Czlowiek();
            c1.Imie = "Jan";
            // c1.Nazwisko = "Kowalski";

            Czlowiek.Nazwisko = "Kowalski";

            Czlowiek c2 = new Czlowiek();
            c1.Imie = "Adam";
            //  c2.Nazwisko = "Nowak";

            Czlowiek.Nazwisko = "Nowak";

            c1.PrzedstawSie();
            c2.PrzedstawSie();

            ManagerTekstu mt = new ManagerTekstu();
            mt.PodajTekst(); // teraz wypisze nowalk

            Console.ReadKey();

        }
    }
}
