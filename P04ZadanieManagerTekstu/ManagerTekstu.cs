using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieManagerTekstu
{
    internal class ManagerTekstu
    {

        public string ZnajdzNajdluzszyWyraz(string zdanie)
        {
            string[] wyrazy= zdanie.Split(' ');

            if (wyrazy.Length < 1)
                throw new Exception("Zdanie jest zbyt krótkie");

            string najdluzszy = wyrazy[0];

            for (int i = 1; i < wyrazy.Length; i++)
                if (wyrazy[i].Length > najdluzszy.Length)
                    najdluzszy = wyrazy[i];

            return najdluzszy;     
        }

        public string[] ZnajdzNajdluzszeWyrazy(string zdanie)
        {
            string najdluzszy = ZnajdzNajdluzszyWyraz(zdanie);

            string[] wszystkie = podajWyrazyODlugosci(najdluzszy.Length, zdanie.Split(' '));
            return wszystkie;
        }

        private string[] podajWyrazyODlugosci(int dlugosc, string[] wyrazy)
        {
            List<string> znalezione = new List<string>();

            foreach (var w in wyrazy)
                if (w.Length == dlugosc)
                    znalezione.Add(w);

            return znalezione.ToArray();
        }

    }
}
