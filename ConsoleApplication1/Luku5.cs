using System;

namespace ConsoleApplication1
{
    class Luku5
    {
        static void Teh1()
        {
            Console.Write("Anna luku: ");
            int luku = int.Parse(Console.ReadLine());

            string teksti = luku % 2 == 0 ? "parillinen" : "pariton";

            Console.WriteLine("Luku {0} on {1}", luku, teksti);
        }
        static void Teh2JaTeh3()
        {
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna operaattori: ");
            string operaattori = Console.ReadLine();
            int lukures = 0;

            // TOTEUTETAAN IF ELSE LAUSEILLA
            /*
            if (operaattori == "+") { lukures = luku1 + luku2; Console.WriteLine("{0} {1} {2} = {3}", luku1, operaattori, luku2, lukures); }
            else if (operaattori == "-") { lukures = luku1 - luku2; Console.WriteLine("{0} {1} {2} = {3}", luku1, operaattori, luku2, lukures); }
            else if (operaattori == "/") { lukures = luku1 / luku2; Console.WriteLine("{0} {1} {2} = {3}", luku1, operaattori, luku2, lukures); }
            else if (operaattori == "*") { lukures = luku1 * luku2; Console.WriteLine("{0} {1} {2} = {3}", luku1, operaattori, luku2, lukures); }
            else if (operaattori == "%") { lukures = luku1 % luku2; Console.WriteLine("{0} {1} {2} = {3}", luku1, operaattori, luku2, lukures); }
            else { Console.WriteLine("Tuntematon operaattori"); }
            */

            // TOTEUTETAAN SWITCH CASE KOMENNOLLA
            switch (operaattori)
            {
                case "+":
                    lukures = luku1 + luku2;Console.WriteLine("{0} {1} {2} = {3}", luku1, operaattori, luku2, lukures);
                    break;
                case "-":
                    lukures = luku1 - luku2;Console.WriteLine("{0} {1} {2} = {3}", luku1, operaattori, luku2, lukures);
                    break;
                case "/":
                    lukures = luku1 / luku2;Console.WriteLine("{0} {1} {2} = {3}", luku1, operaattori, luku2, lukures);
                    break;
                case "*":
                    lukures = luku1 * luku2;Console.WriteLine("{0} {1} {2} = {3}", luku1, operaattori, luku2, lukures);
                    break;
                case "%":
                    lukures = luku1 % luku2;Console.WriteLine("{0} {1} {2} = {3}", luku1, operaattori, luku2, lukures);
                    break;
                default:
                    Console.WriteLine("Tuntematon operaattori"); 
                    break;
            }

            int lobos = 5;

            switch (lobos)
            {
                case 5:
                case 6:
                    Console.WriteLine("HAHA");
                    break;
            }

        }
    }
}
