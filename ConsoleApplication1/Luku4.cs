using System;

namespace ConsoleApplication1
{
    class Luku4
    {
        static void Teh1()
        {
            Console.Write("Anna luku: ");
            int luku = int.Parse(Console.ReadLine());
            int dluku = luku*2;
            Console.WriteLine("2 * {0} = {1}", luku, dluku);
        }

        static void Teh2()
        {
            Console.Write("Anna ensimmäinen luku: ");
            int enluku = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int toluku = int.Parse(Console.ReadLine());
            int loluku = enluku + toluku;
            Console.WriteLine("{0} + {1} = {2}", enluku, toluku, loluku);
        }
        static void Teh3()
        {
            Console.Write("Anna jaettava: ");
            int divtar = int.Parse(Console.ReadLine());
            Console.Write("Anna jakaja: ");
            int divider = int.Parse(Console.ReadLine());
            double resdiv = divtar / divider;
            int redfrac = divtar % divider;
            Console.WriteLine("{0} / {1} = {2}, jää {3}", divtar, divider, resdiv, redfrac);
        }
        static void Teh4()
        {
            Console.Write("Anna luku: ");
            int luku = int.Parse(Console.ReadLine()); ;
            int lukuY = luku % 10;
            int lukuK = (luku - lukuY)/10;
            Console.WriteLine("Ykköset: {0}", lukuY);
            Console.WriteLine("Kymmenet: {0}", lukuK);
        }
    }
}
