using System;

namespace ConsoleApplication1
{
    class Luokka11_1 : ILiittyma
    {
        public int Luku { get; set; }
        public string Teksti { get; set; }
        public int LukuPlusYksi()
        {
            return Luku + 1;
        }
        public void Tulosta()
        {
            Console.WriteLine("Luku on " + Luku);
            Console.WriteLine("Teksti on " + Teksti);
        }
    }
    class Ohjelma11_1
    {
        static void Run()
        {
            ILiittyma liittyma = new Luokka11_1();
            liittyma.Luku = 123;
            liittyma.Teksti = "Hei maailma!";
            liittyma.Tulosta();
            Console.WriteLine("Luku + 1 = " + liittyma.LukuPlusYksi());
        }
    }

    interface ILiittyma
    {
        int Luku { get; set; }
        string Teksti { get; set; }
        int LukuPlusYksi();
        void Tulosta();
    }

}