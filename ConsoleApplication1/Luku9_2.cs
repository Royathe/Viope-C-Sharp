using System;

namespace ConsoleApplication1
{
    class Ohjelma2
    {
        static void Run()
        {
            Luokka2 luokka = new Luokka2();
            luokka.Luku1 = 3.7;
            luokka.Luku2 = 2.1;

            Console.WriteLine("{0} + {1} = {2}", luokka.Luku1, luokka.Luku2, luokka.Summa());
            Console.WriteLine("{0} - {1} = {2}", luokka.Luku1, luokka.Luku2, luokka.Erotus());
            Console.WriteLine("{0} * {1} = {2}", luokka.Luku1, luokka.Luku2, luokka.Tulo());
            Console.WriteLine("{0} / {1} = {2}", luokka.Luku1, luokka.Luku2, luokka.Osamaara());
            Console.WriteLine("{0} % {1} = {2}", luokka.Luku1, luokka.Luku2, luokka.Jakojaannos());

        }
    }

    class Luokka2
    {
        public double Luku1;
        public double Luku2;

        public double Summa()
        {
            double tulos = Luku1 + Luku2;
            return tulos;
        }
        public double Erotus()
        {
            double tulos = Luku1 - Luku2;
            return tulos;
        }
        public double Tulo()
        {
            double tulos = Luku1 * Luku2;
            return tulos;
        }
        public double Osamaara()
        {
            double tulos = Luku1 / Luku2;
            return tulos;
        }
        public double Jakojaannos()
        {
            double tulos = Luku1 % Luku2;
            return tulos;
        }
    }
}