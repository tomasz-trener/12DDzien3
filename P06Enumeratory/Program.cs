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
            KalkulatorUniwersalny ku = new KalkulatorUniwersalny();
            ku.WykonajOperacje(4, 5, TypOperacji.Dodawanie);


        }
    }
}
