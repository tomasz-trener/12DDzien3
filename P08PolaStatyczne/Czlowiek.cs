using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08PolaStatyczne
{
    internal class Czlowiek
    {
        public string Imie;
        public static string Nazwisko;


        // metoda void nic nie zwraca
        public void PrzedstawSie()
        {
            string s = "Nazywam sie" + Imie + " " + Nazwisko;
            Console.WriteLine(s);
        }

        public static void PodajJakSieNazywasz()
        {
            string s = Nazwisko;
            Console.WriteLine("Jestem " + s);
        }

    }
}
