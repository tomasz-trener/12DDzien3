using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieZawodnicy
{
    internal class Zawodnik
    {
        public int Id;
        public int? Id_trenera;
        public string Imie;
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUrodzenia;
        public int Wzrost;
        public int Waga;

        public string PrzedstawSie()
        {
            return $"Nazywam się {Imie} {Nazwisko} i pochodzę z {Kraj}";
        }
    }
}
