using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WlasneKlasy
{
    internal class Kalkulator
    { // ciało klasy 

        //mozemy zadeklarowac 4 elementy 
        // 1) pola -> cechy obiektu (jaki on jest)  
        // 2) własciwosci -> to samo co pola (ale troszkę bardziej rozbudowane) 
        // 3) konstruktory -> określają w jak sposób możemy tworzyć obiekt (u nas kalkulator) 
        // 4) metody -> umiejętności (co dany obiekt potrafi zrobić) 

        private int dodaj(int a, int b)
        {
            // ciało metody 
            string s = "ala ma kota ";
            s = s.ToUpper();

            int c = a + b;

            return c; 
        }

        public int Przemnoz(int a, int b)
        {
            // return a * b;
            int wynik = 0;
            for (int i = 0; i < b; i++)
                wynik = dodaj(wynik, a);

            return wynik;
        }

    }
}
