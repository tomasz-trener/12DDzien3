using System;

namespace P12ManagerZawodnikow
{
    public class Zawodnik
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