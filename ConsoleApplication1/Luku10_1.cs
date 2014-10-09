using System;

namespace ConsoleApplication1
{
    class Ohjelma10_1
    {
        static void Run()
        {
            Luokka10_1 luokka = new Luokka10_1(3);
            luokka[0] = 1;
            luokka[1] = 2;
            luokka[2] = 3;
            luokka[3] = 4;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(luokka[i]);
            }
        }
    }

    class Luokka10_1
    {
        private int[] indexer;

        public Luokka10_1(int size)
        {
            indexer = new int[size];
        }

        public int this[int i]
        {
            get
            {
                return indexer[i];
            }
            set
            {
                try
                {
                    indexer[i] = value;
                    Console.WriteLine("Luku lisätty");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ei ole tilaa");
                }
            }
        }
    }

}