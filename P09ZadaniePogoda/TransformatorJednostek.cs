using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadaniePogoda
{
    enum Jednostka
    {
        Celcjusz =3,
        Kelvin =2,
        Farenheit=1,
        Newtony=4
    }
    internal class TransformatorJednostek
    {
        public double ZamienTemprature(int wartosc, Jednostka jednokaDocelowa, Jednostka jednostkaWejsciowa)
        {
            if (jednostkaWejsciowa == jednokaDocelowa)
                return wartosc;

            if (jednostkaWejsciowa == Jednostka.Celcjusz && jednokaDocelowa == Jednostka.Farenheit)
                return (wartosc * 1.8) + 32;

            if (jednostkaWejsciowa == Jednostka.Celcjusz && jednokaDocelowa == Jednostka.Kelvin)
                return wartosc+273.15;

            if (jednostkaWejsciowa == Jednostka.Farenheit && jednokaDocelowa == Jednostka.Celcjusz)
                return (wartosc-32)/1.8;

            if (jednostkaWejsciowa == Jednostka.Farenheit && jednokaDocelowa == Jednostka.Kelvin)
                return (wartosc+459.67)*5/9;

            if (jednostkaWejsciowa == Jednostka.Kelvin && jednokaDocelowa == Jednostka.Celcjusz)
                return wartosc-273.15;

            if (jednostkaWejsciowa == Jednostka.Kelvin && jednokaDocelowa == Jednostka.Farenheit)
                return (wartosc * 1.8) - 459.67;

           // return wartosc;
            throw new Exception("Podano nieznana jednostke");
        }
    }
}
