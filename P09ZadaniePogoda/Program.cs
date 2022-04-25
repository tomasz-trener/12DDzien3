using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody mp = new ManagerPogody();
            mp.PodajTemperature("Warszawa");
            Console.ReadKey();
        }
    }
}
