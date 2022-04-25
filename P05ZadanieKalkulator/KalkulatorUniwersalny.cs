using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Pola
{
    internal class KalkulatorUniwersalny
    {
        public double WykonajOperacje(int a, int b, char operacja)
        {
            if (operacja == '+')
            {
                KalkulatorDodajacy kd = new KalkulatorDodajacy();
                int c= kd.Dodaj(a, b);
                return c;
               // ZwiekszaczLiczb zl = new ZwiekszaczLiczb();
               // int d= zl.Zwieksz(c);
            }

            if (operacja == '-')
                return new KalkulatorOdejmujacy().Odejmij(a, b);

            throw new Exception("Nieznana operacja");

        }
    }
}
