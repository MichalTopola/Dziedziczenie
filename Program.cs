using System;

namespace DziedziczenieMarkI
{
    class Program
    {
        class Zwierze
        {
            protected string imie;
            protected string kolor;
            protected int wiek;
            protected string gatunek;
            protected string dzwiek;
            public void Ustaw(string i, string k, string g, int w)
            {
                imie = i;
                kolor = k;
                gatunek = g;
                wiek = w;
            }

            public string Wydawjdzwiek(string dz)
            {
                dzwiek = dz;
                return dz;
            }
        };
        class kot : Zwierze
        {
            public string informacje()
            {

                return imie + kolor + gatunek;
            }
            static void Main(string[] args)
            {
                kot Filemon = new kot();

                Filemon.Ustaw("Filemon", " Bialy", " Kot", 3);
                Console.WriteLine(Filemon.informacje()+" 3 lata");

                Console.ReadLine();
            }
        }
    }
}
