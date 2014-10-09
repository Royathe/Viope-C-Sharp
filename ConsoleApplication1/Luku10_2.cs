using System;

namespace ConsoleApplication1
{
    class Ohjelma10_2
    {
        static void Run()
        {
            double[] luvut = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double summa = Laskin.Summa(luvut);
            double keskiarvo = Laskin.Keskiarvo(luvut);
            Console.WriteLine("Ensimmäisten lukujen summa on {0} ja keskiarvo {1:f2}", summa, keskiarvo);

            double summa2 = Laskin.Summa(1.1, 2.2, 3.3);
            Console.WriteLine("Seuraavien lukujen summa on {0}", summa2);

            double keskiarvo2 = Laskin.Keskiarvo(1.2, 2.3, 3.4, 4.5, 5.6, 6.7);
            Console.WriteLine("Kolmansien lukujen keskiarvo on {0:f2}", keskiarvo2);

        }
    }

    class Laskin
    {
        static bool run = false;

        public static double Summa(double[] luvut)
        {
            if (run == false)
            {
                Console.WriteLine("Laskin alustettu");
                run = true;
            }
            double summa = 0;

            for (int i = 0; i < luvut.Length; i++)
            {
                summa += luvut[i];
            }
            return summa;
        }

        public static double Summa(double luku1, double luku2, double luku3)
        {
            double summa = luku1 + luku2 + luku3;
            return summa;
        }

        public static double Keskiarvo(double[] luvut)
        {
            double summa = 0;

            foreach (double num in luvut)
            {
                summa += num;
            }
            double keskiarvo = summa / luvut.Length;
            return keskiarvo;
        }

        public static double Keskiarvo(double luku1, double luku2, double luku3, double luku4, double luku5, double luku6)
        {
            double keskiarvo = (luku1 + luku2 + luku3 + luku4 + luku5 + luku6)/6;
            return keskiarvo;
        }


    }
}