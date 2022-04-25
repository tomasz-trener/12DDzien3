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
        public double WykonajOperacje(int a, int b, TypOperacji operacja)
        {
            if (operacja == TypOperacji.Dodawanie)
            {
                KalkulatorDodajacy kd = new KalkulatorDodajacy();
                int c= kd.Dodaj(a, b);
                return c;
               // ZwiekszaczLiczb zl = new ZwiekszaczLiczb();
               // int d= zl.Zwieksz(c);
            }

            if (operacja == TypOperacji.Odejmowanie)
                return new KalkulatorOdejmujacy().Odejmij(a, b);

            throw new Exception("Nieznana operacja");

        }
    }
}
