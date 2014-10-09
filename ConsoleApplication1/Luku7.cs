using System;

namespace ConsoleApplication1
{
    class Luku7
    {
        static void Teh3()
        {
            int luku1 = 0;
            bool first = false;
            string appender = "";

            do
            {

                Console.Write("Anna "+appender+"luku: ");
                try
                {
                    luku1 = int.Parse(Console.ReadLine());
                    first = true;
                }
                catch (FormatException) { first = false; appender = ""; }
                catch (OverflowException) {first = false; appender = "pienempi "; }

            } while (first == false);
            Console.WriteLine(luku1);
        }

        static void Teh2()
        {
            int luku1 = 0;
            int luku2 = 0;

            Console.Write("Anna jaettava: ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna jakaja: ");
            luku2 = int.Parse(Console.ReadLine());

            if (luku2 == 0)
            {
                Console.WriteLine("Nollalla ei voi jakaa");
            }
            else
            {
                double tulos = (double)luku1 / luku2;
                Console.WriteLine("{0} / {1} = {2:f2}", luku1, luku2, tulos);
            }
        }

        static void Teh1()
        {
            bool first = false;
            bool second = false;
            int luku1 = 0;
            int luku2 = 0;

            do{

                Console.Write("Anna ensimmäinen luku: ");
                try
                {
                    luku1 = int.Parse(Console.ReadLine());
                    first = true;
                }
                catch (FormatException)
                {
                    first = false;
                }

            }while(first == false);

            do
            {

                Console.Write("Anna toinen luku: ");
                try
                {
                    luku2 = int.Parse(Console.ReadLine());
                    second = true;
                }
                catch (FormatException)
                {
                    second = false;
                }

            } while (second == false);

            Console.WriteLine("{0} + {1} = {2}",luku1, luku2, (luku1+luku2));

        }
    }
}
