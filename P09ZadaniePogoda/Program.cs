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
           
            string s1= mp.PodajTemperature("Warszawa");
            string s2 = mp.PodajTemperature("Warszawa", Jednostka.Kelvin);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            
            Console.ReadKey();

            TransformatorJednostek tj = new TransformatorJednostek();


            Console.WriteLine("Podaj jednostke nr");
            string jednostka = Console.ReadLine();

            // konwersja z int na enumerator 
            Jednostka jd2 =
                (Jednostka)Enum.Parse(typeof(Jednostka), jednostka);

            // konwersja z int na enumerator (samym rzutowaniem)
            int a = 4;
            Jednostka jd4 = (Jednostka)a;

            //konwersja string na enumerator
            Jednostka jd3;
            Enum.TryParse(jednostka, out jd3);


            Jednostka? jd=null;
            if (jednostka == "Celcjusz")
                jd = Jednostka.Celcjusz;
            else if (jednostka == "Kelvin")
                jd = Jednostka.Kelvin;
            else
                Console.WriteLine("Nieznana jednostka");


            if (jd != null)
            {
                double wynik = tj.ZamienTemprature(10, (Jednostka)jd, Jednostka.Newtony);
                Console.WriteLine(wynik);
            }


        }
    }
}
