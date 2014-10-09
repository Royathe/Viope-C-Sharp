using System;

namespace ConsoleApplication1
{
    class Luku12
    {
        static void Run()
        {
            teh2();
        }
        static void teh2()
        {
            Console.Write("Syötä teksti: ");
            string tiedosto = Console.ReadLine();

            tiedosto.ToLower();

            string[] sanat = tiedosto.Split(new[]{' ',',','.'},StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sanat.Length; i++)
            {
                Console.Write("{0}  {1}", sanat[i], sanat[i].Length);
                Console.WriteLine();
            }

        }

        static void teh1()
        {
            Console.Write("Anna tiedostonimi: ");
            string tiedosto = Console.ReadLine();

            int paikka = tiedosto.LastIndexOf(".");
            if (paikka != -1)
            {
                string paate = tiedosto.Substring(paikka + 1);
                Console.WriteLine(paate);
            }
            else
            {
                Console.WriteLine("ei tiedostopäätettä");
            }
        }
    }
}