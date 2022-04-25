using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Pola
{
    enum TypOperacji
    {
        Dodawanie,
        Odejmowanie
    }


    internal class KalkulatorUniwersalny
    {

        public int Waga;
        public TypOperacji TypOperacji;

        public double WykonajOperacje(int a, int b)
        {
            if (TypOperacji == TypOperacji.Dodawanie)
            {
                KalkulatorDodajacy kd = new KalkulatorDodajacy();
                int c= kd.Dodaj(a, b);
                return c;
               // ZwiekszaczLiczb zl = new ZwiekszaczLiczb();
               // int d= zl.Zwieksz(c);
            }

            if (TypOperacji == TypOperacji.Odejmowanie)
                return new KalkulatorOdejmujacy().Odejmij(a, b);

            throw new Exception("Nieznana operacja");
        }
    }
}
