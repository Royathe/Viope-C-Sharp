using System;

namespace ConsoleApplication1
{
    class Ohjelma10_3
    {
        static void Run()
        {
            Kokoelma kokoelma = new Kokoelma(3);
            kokoelma["kokonaisluku"] = 123;
            kokoelma["desimaaliluku"] = 456.78;
            kokoelma["teksti"] = "Hei maailma!";

            double summa = (double)(int)kokoelma["kokonaisluku"] + (double)kokoelma["desimaaliluku"];
            Console.WriteLine("Numeeristen arvojen summa on {0}", summa);

            Console.WriteLine();

            Kokoelma kokoelma2 = new Kokoelma(2);
            kokoelma2["kokonaisluku"] = 123;
            kokoelma2["desimaaliluku"] = 456.78;
            kokoelma2["teksti"] = "Hei maailma!";
        }
    }

    class Kokoelma
    {
        private int maxinput = 0;
        private int kokonaisluku;
        private double desimaaliluku;
        private string teksti;

        public object this[string indeksi]
        {
            get
            {
                object returnable = 0;
                if (indeksi == "kokonaisluku")
                {
                    returnable = kokonaisluku;
                }
                else if (indeksi == "desimaaliluku")
                {
                    returnable = desimaaliluku;
                }
                return returnable;
            }
            set
            {
                if (maxinput > 0)
                {
                    if (indeksi == "desimaaliluku")
                    {
                        desimaaliluku = Convert.ToDouble(value);
                        Console.WriteLine("Lisätty desimaaliluku = " + desimaaliluku);
                        this.maxinput--;
                    }
                    else if (indeksi == "kokonaisluku")
                    {
                        kokonaisluku = Convert.ToInt32(value);
                        Console.WriteLine("Lisätty kokonaisluku = " + kokonaisluku);
                        this.maxinput--;
                    }
                    else if (indeksi == "teksti")
                    {
                        teksti = Convert.ToString(value);
                        Console.WriteLine("Lisätty teksti = " + teksti);
                        this.maxinput--;
                    }
                }
                else
                {
                    Console.WriteLine("Kokoelma on täynnä");
                }
            }
        }

        public Kokoelma(int size)
        {
            maxinput = size;
        }
    }
}