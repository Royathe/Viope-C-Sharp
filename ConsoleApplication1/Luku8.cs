using System;

namespace ConsoleApplication1
{
    class Luku8
    {
        static void Teh3()
        {

            Console.WriteLine("Kuinka monta lukua? ");
            int arlength = int.Parse(Console.ReadLine());

            int[] a = new int[arlength];
            int rep = 0;

            do
            {
                Console.Write("Anna {0}. luku: ",rep+1);
                a[rep] = int.Parse(Console.ReadLine());
                rep++;
            }while(rep < a.Length);

            Array.Sort(a);
            /*
            foreach (int number in a)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();*/

            for (int i = 0; i <= 10; i++)
            {
                int count = 0;
                if((Array.IndexOf(a, i) > -1)){
                    count = (Array.LastIndexOf(a, i)+1) -(Array.IndexOf(a, i));
                    //Console.WriteLine("LAST INDEX OF {0}:"+(Array.LastIndexOf(a, i)+1) + "     FIRST INDEX OF {0}:" + (Array.IndexOf(a, i)),i);
                    //Console.WriteLine(count);
                }

                if (count > 0) { Console.WriteLine("Luku {0} esiintyi {1} kertaa", i, count); }
            }
        }

        static void Teh2()
        {
            int[,] t = new int[4, 4];

            Console.Write("Anna luku kohtaan [0,0]: ");
            t[0, 0] = int.Parse(Console.ReadLine());

            Console.Write("Anna luku kohtaan [0,1]: ");
            t[0, 1] = int.Parse(Console.ReadLine());

            Console.Write("Anna luku kohtaan [0,2]: ");
            t[0, 2] = int.Parse(Console.ReadLine());

            t[0, 3] = t[0, 1] + t[0, 2] + t[0, 0];

            Console.Write("Anna luku kohtaan [1,0]: ");
            t[1, 0] = int.Parse(Console.ReadLine());

            Console.Write("Anna luku kohtaan [1,1]: ");
            t[1, 1] = int.Parse(Console.ReadLine());

            Console.Write("Anna luku kohtaan [1,2]: ");
            t[1, 2] = int.Parse(Console.ReadLine());

            t[1, 3] = t[1, 1] + t[1, 2] + t[1, 0];

            Console.Write("Anna luku kohtaan [2,0]: ");
            t[2, 0] = int.Parse(Console.ReadLine());

            Console.Write("Anna luku kohtaan [2,1]: ");
            t[2, 1] = int.Parse(Console.ReadLine());

            Console.Write("Anna luku kohtaan [2,2]: ");
            t[2, 2] = int.Parse(Console.ReadLine());

            t[2, 3] = t[2, 1] + t[2, 2] + t[2, 0];

            t[3, 0] = t[0, 0] + t[2, 0] + t[1, 0];
            t[3, 1] = t[0, 1] + t[2, 1] + t[1, 1];
            t[3, 2] = t[0, 2] + t[2, 2] + t[1, 2];
            t[3, 3] = t[0, 3] + t[2, 3] + t[1, 3];

            for (int y = 0; y < t.GetLength(0); y++)
            {
                for (int x = 0; x < t.GetLength(1); x++)
                {
                    Console.Write(t[y,x]+" ");
                }
                Console.WriteLine();
            }
        }

        static void Teh1()
        {
            Console.Write("Anna 1. luku: ");
            int luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna 2. luku: ");
            int luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna 3. luku: ");
            int luku3 = int.Parse(Console.ReadLine());

            Console.Write("Anna 4. luku: ");
            int luku4 = int.Parse(Console.ReadLine());

            Console.Write("Anna 5. luku: ");
            int luku5 = int.Parse(Console.ReadLine());

            int summa = luku1 + luku2 + luku3 + luku4 + luku5;
            double keskiarvo = (double)summa / 5;

            Console.WriteLine(luku1 + " + " + luku2 + " + " + luku3 + " + " + luku4 + " + " + luku5 + " = " + summa);
            Console.WriteLine(summa + " / 5 = {0:f1}" , keskiarvo);
        }
    }
}
