using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Pola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KalkulatorUniwersalny ku1 = new KalkulatorUniwersalny();

            ku1.Waga = 10;
            ku1.TypOperacji = TypOperacji.Dodawanie;

            KalkulatorUniwersalny ku2 = new KalkulatorUniwersalny();
            ku2.Waga = 20;
            ku2.TypOperacji = TypOperacji.Odejmowanie;


            double wynik1 = ku1.WykonajOperacje(4, 5); // tutaj dodaje
            double wynik2 = ku2.WykonajOperacje(4, 5); // tutaj odejmuje


        }
    }
}
