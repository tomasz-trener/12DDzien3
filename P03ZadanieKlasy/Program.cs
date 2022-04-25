using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();
            
            double w= k.Policz("234*32");
            Console.WriteLine(w);


        }
    }
}
