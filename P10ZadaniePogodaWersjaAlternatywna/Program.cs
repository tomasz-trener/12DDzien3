using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadaniePogodaWersjaAlternatywna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody mp = new ManagerPogody();
            string s1= mp.PodajTemperature("Warszawa"); // domyslnei celcjus

            mp.Jednostka = Jednostka.Farenheit;
            string s2 = mp.PodajTemperature("Warszawa"); // od teraz bede bral temperature w farenheitech

            //przerwa 13:20

        }
    }
}
