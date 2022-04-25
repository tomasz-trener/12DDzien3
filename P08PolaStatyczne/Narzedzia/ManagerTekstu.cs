using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08PolaStatyczne.Narzedzia
{
    internal class ManagerTekstu
    {

        public void PodajTekst()
        {
            string s = Czlowiek.Nazwisko;
            Console.WriteLine(s);
        }
    }
}
