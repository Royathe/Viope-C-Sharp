using System;

namespace ConsoleApplication1
{
    class Luku6
    {
        static void Tester()
        {
            for (int a = 1, b = 0; a < 5 && b <= 5; a++, b += 2)
            {
                Console.Write(a);
                Console.Write(b);
            }
        }

        static void Teh1()
        {
            Console.Write("Anna leveys: ");
            int leveys = int.Parse(Console.ReadLine());
            Console.Write("Anna korkeus: ");
            int korkeus = int.Parse(Console.ReadLine());

            //FOR LOOP KÄYTTÄEN (TEHTÄVÄ 1)
            for (int y = 0; y < korkeus; y++)
            {
                for (int x = 0; x < leveys; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            

            //DO WHILE KÄYTTÄEN (TEHTÄVÄ 2)
            /*
            int y = 0;

            do
            {
                int x = 0;

                do
                {
                    x++;
                    Console.Write("*");
                } while (x < leveys);
                y++;
                Console.WriteLine("");
            } while (y < korkeus);
            */
        }

        static void Teh2()
        {

            Console.Write("Anna teksti: ");
            string teksti = Console.ReadLine();

            foreach (char merkki in teksti)
            {
                int asc = (int)merkki;
                Console.WriteLine(merkki + " " + asc);
            }

        }
        static void Teh3()
        {
            bool input = false;
            int korkeus = 0;
            do{
                Console.Write("Anna korkeus: ");
                korkeus = int.Parse(Console.ReadLine());
                if (korkeus > 0) { input = true; }
            }while(input == false);

            //FOR LOOP KÄYTTÄEN (TEHTÄVÄ 4)
            /*
            for (int y = 1; y <= korkeus; y++)
            {
                for (int x = korkeus-y; x > 0; x--)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < y + (y - 1); x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            */

            //DO WHILE KÄYTTÄEN (TEHTÄVÄ 5)
            int y = 1;
            do
            {
                int empty = korkeus - y;
                do
                {
                    if (empty != 0)
                    {
                        Console.Write(" ");
                    }
                    empty--;
                }while(empty >= 0);


                int leveys = y + (y - 1);
                do
                {
                    Console.Write("*");
                    leveys--;
                } while (leveys > 0);

                y++;
                Console.WriteLine("");
            }while(y <= korkeus);
        }
    }
}
