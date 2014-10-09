using System;

namespace ConsoleApplication1
{
    class Luku2
    {
        static void LukuMethod()
        {
            Console.Write("Anna etunimi: ");
            string enimi = Console.ReadLine();
            Console.Write("Anna sukunimi: ");
            string snimi = Console.ReadLine();
            Console.WriteLine("{0} {1}", enimi, snimi);
        }
    }
}
