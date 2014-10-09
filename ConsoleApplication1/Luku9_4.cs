using System;

namespace ConsoleApplication1
{
    class Ohjelma4
    {
        static void Run()
        {
            Tuote maito = new Tuote { Nimi = "Maito", Hinta = 0.99M };
            Tuote paahtoleipa = new Tuote { Nimi = "Paahtoleipä", Hinta = 2.79M };
            Tuote kananmunat = new Tuote { Nimi = "Kananmunat 6kpl", Hinta = 2.40M };
            Tuote murot = new Tuote { Nimi = "Murot", Hinta = 3.20M };

            Ostoskori ostoskori = new Ostoskori();
            ostoskori.LisaaTuote(maito, 2);
            ostoskori.LisaaTuote(kananmunat);
            ostoskori.LisaaTuote(paahtoleipa);
            Console.WriteLine("Ensimmäisen ostoskorin summa: {0:f2}", ostoskori.LaskeYhteishinta());

            Console.WriteLine();

            Ostoskori ostoskori2 = new Ostoskori();
            ostoskori2.LisaaTuote(maito, 3);
            ostoskori2.LisaaTuote(kananmunat);
            ostoskori2.LisaaTuote(paahtoleipa);
            ostoskori2.LisaaTuote(murot);
            Console.WriteLine("Toisen ostoskorin summa: {0:f2}", ostoskori2.LaskeYhteishinta());
        }
    }

    class Tuote
    {
        public decimal Hinta;
        public string Nimi;
    }

    class Ostoskori
    {
        decimal summa;
        int tila;
        public Ostoskori()
        {
            this.summa = 0;
            this.tila = 5;
        }

        public void LisaaTuote(Tuote tuote)
        {
            Console.WriteLine(tila);
                if (tila > 0)
                {
                    Console.WriteLine("Tuote \"{0}\" lisätty koriin", tuote.Nimi);
                    this.summa += (tuote.Hinta);
                    tila--;
                }
                else
                {
                    Console.WriteLine("Tuote \"{0}\" ei mahtunut koriin", tuote.Nimi);
                }
        }
        public void LisaaTuote(Tuote tuote, int maara)
        {
            do
            {
                if (tila > 0)
                {
                    Console.WriteLine("Tuote \"{0}\" lisätty koriin", tuote.Nimi);
                    this.summa += (tuote.Hinta);
                    maara--;
                    tila--;
                }
                else
                {
                    Console.WriteLine("Tuote \"{0}\" ei mahtunut koriin", tuote.Nimi);
                }
            } while (maara != 0 && tila != 0);
        }
        public decimal LaskeYhteishinta()
        {
            return summa;
        }

    }

}