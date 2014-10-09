using System;
using System.IO;

namespace ConsoleApplication1
{
    class Luku13
    {
        static void Main()
        {
            teh3();
        }

        static void teh3()
        {
            string tiedosto = "input.txt";
            using (StreamReader sr = new StreamReader(tiedosto))
            {
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string rivi = sr.ReadLine();
                        string[] numerot = rivi.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        int summa = 0;
                        for (int i = 0; i < numerot.Length; i++)
                        {
                            summa += Convert.ToInt32(numerot[i]);
                            Console.Write(numerot[i] + " ");
                            sw.Write(numerot[i] + " ");
                        }
                        if (summa != 0)
                        {
                            sw.Write(summa);
                            Console.Write(summa);
                            sw.WriteLine();
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        static void teh2()
        {
            string tiedosto = "teksti.txt";

            string teksti = System.IO.File.ReadAllText(tiedosto);
            int indeksi = teksti.IndexOf("x");
            string patka = teksti.Substring(0, indeksi+1);
            Console.WriteLine(patka);
        }

        static void teh1()
        {
            string tiedosto = "numerot.txt";

            string[] rivit = System.IO.File.ReadAllLines(tiedosto);
            int summa = 0;

            for (int i = 0; i < rivit.Length; i++)
            {
                try
                {
                    summa += Convert.ToInt32(rivit[i]);
                }catch(Exception){}
            }
            Console.WriteLine(summa);

        }
    }
}