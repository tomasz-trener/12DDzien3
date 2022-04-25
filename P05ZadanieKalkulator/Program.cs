using P07Pola.NarzedziaPomocnicze;
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
            KalkulatorUniwersalny kd = new KalkulatorUniwersalny();
            double wyn= kd.WykonajOperacje(3, 5, '+');

            ZwiekszaczLiczb zl = new ZwiekszaczLiczb();
            int a= zl.Zwieksz(Convert.ToInt32(wyn));

            int b= ZwiekszaczLiczb.Zwieksz2(Convert.ToInt32(wyn));
          
            //  ZwiekszaczLiczb zl2 = new ZwiekszaczLiczb();

        }
    }
}
