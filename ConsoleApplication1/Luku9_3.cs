using System;

namespace ConsoleApplication1
{
    class Ohjelma3
    {
        static void Run()
        {

            Tuote3[] ostokset = new Tuote3[2];
            Tuoteryhma3 kodinkoneRyhma = new Tuoteryhma3("Kodinkoneet");
            ostokset[0] = new Tuote3("Kahvinkeitin", kodinkoneRyhma, 49.90M);
            ostokset[1] = new Tuote3("Mikroaaltouuni", kodinkoneRyhma);
            ostokset[1].Hinta = 99.90M;
            decimal summa = 0;
            foreach (Tuote3 t in ostokset)
            {
                summa += t.Hinta;
                Console.WriteLine(t.Yhteenveto);
            }
            Console.WriteLine("Yhteensä {0:f2}", summa);
        }
    }

    class Tuote3
    {
        public decimal Hinta;
        public string Nimi;
        public Tuoteryhma3 Ryhma;
        public String Yhteenveto
        {
            get
            {
                return (Ryhma.Nimi + ": " + Nimi + " " + Hinta);
            }
        }

        public Tuote3(string nimi, Tuoteryhma3 ryhma, decimal hinta)
        {
            Nimi = nimi;
            Ryhma = ryhma;
            Hinta = hinta;
        }
        public Tuote3(string nimi, Tuoteryhma3 ryhma)
        {
            Nimi = nimi;
            Ryhma = ryhma;
        }
    }
    class Tuoteryhma3
    {
        public string Nimi;

        public Tuoteryhma3(string nimi)
        {
            this.Nimi = nimi;
        }
    }
}