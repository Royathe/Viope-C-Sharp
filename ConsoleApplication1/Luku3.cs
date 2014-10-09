using System;

namespace ConsoleApplication1
{
    class Luku3
    {
        static void tester()
        {
            int luku = 5;
            Console.WriteLine(luku < 7);
        }
        static void Teh1()
        {
            Console.Write("Anna luku: ");
            double luku = double.Parse(Console.ReadLine());
            int rluku = (int)luku;
            Console.WriteLine("{0}", rluku);
        }

        static void Teh2()
        {
            Console.Write("Anna luku: ");
            int luku = int.Parse(Console.ReadLine());
            char symbol = (char)luku;
            Console.WriteLine("{0}", symbol);
        }

        static void Teh3()
        {
            Console.Write("Anna luku: ");
            float luku = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", luku);
        }
    }
}
