using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01PytanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis1 = "ala ma kota";
            string napis2 = "pies";

            string napis3 = napis1 + napis2;
            napis3 = napis3.Replace(" ", "");

            //char[] znaki = napis3.ToArray().Distinct().ToArray();
            char[] znaki = napis3.ToArray();
            Array.Sort(znaki);

            List<char> znakiLista = new List<char>();
            for (int i = 0; i < znaki.Length; i++)
                if (!znakiLista.Contains(znaki[i]))
                    znakiLista.Add(znaki[i]);
            
            string wynik = new string(znakiLista.ToArray());

            Console.WriteLine(wynik);
            Console.ReadKey();
            





        }
    }
}
