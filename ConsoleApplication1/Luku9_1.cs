using System;

namespace ConsoleApplication1
{
    class Ohjelma1
    {
        static void Run()
        {
            string otsikko = "Otsikko";
            Blogimerkinta merkinta = new Blogimerkinta(otsikko);
            merkinta.Teksti = "Teksti";
            merkinta.Avainsanat = new string[] { "Eka", "Toka" };
            merkinta.Tulosta();
        }
    }

    class Blogimerkinta
    {
        public string Teksti;
        public string[] Avainsanat;
        string Otsikko;

        public Blogimerkinta(string otsikko)
        {
            this.Otsikko = otsikko;
        }

        public void Tulosta()
        {
            Console.WriteLine(Otsikko);
            Console.WriteLine(Teksti);
            Console.Write("Avainsanat: ");
            Console.Write(Avainsanat[0]);
            for (int i = 1; i < Avainsanat.Length; i++)
            {
                Console.Write(", {0}",Avainsanat[i]);
            }

        }
    }
}