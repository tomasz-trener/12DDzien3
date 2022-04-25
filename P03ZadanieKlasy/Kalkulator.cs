using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieKlasy
{
    internal class Kalkulator
    {

        public double Policz(string rownanie)
        {
           string[] tab1= rownanie.Split('+');
           string[] tab2 = rownanie.Split('-');
           string[] tab3 = rownanie.Split('*');
           string[] tab4 = rownanie.Split('/');

            double? wynik=null;

            if (tab1.Length == 2)
                wynik = Convert.ToInt32(tab1[0]) + Convert.ToInt32(tab1[1]);

            if (tab2.Length == 2)
                wynik = Convert.ToInt32(tab2[0]) - Convert.ToInt32(tab2[1]);

            if (tab3.Length == 2)
                wynik = Convert.ToInt32(tab3[0]) * Convert.ToInt32(tab3[1]);

            if (tab4.Length == 2)
                wynik = Convert.ToInt32(tab4[0]) / Convert.ToInt32(tab4[1]);


            if (wynik != null)
                return (double)wynik;
            else
                throw new Exception("Podano zly operator"); // throw zastepuje return 
        }

    }
}
