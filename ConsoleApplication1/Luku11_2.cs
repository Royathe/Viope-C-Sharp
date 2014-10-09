using System;

namespace ConsoleApplication1
{
    class Luokka
    {
        public virtual string Teksti { get; set; }

        public Luokka(string teksti)
        {
            char[] merkit = teksti.ToCharArray();
            Array.Reverse(merkit);
            this.Teksti = new string(merkit);
        }

        public virtual string MuodostaTeksti()
        {
            return Teksti;
        }
    }



    class PerivaLuokka : Luokka
    {

        public string teksti;

        public PerivaLuokka(string teksti1, string teksti2) : base(teksti1) 
        {
            teksti = teksti2 + " " + base.Teksti;
        }

        public override string MuodostaTeksti()
        {
            return teksti;
        }
    }



    class Ohjelma11_2
    {
        static void Run()
        {
            Luokka luokka = new PerivaLuokka("!amliaam", "hei");
            Console.WriteLine(luokka.MuodostaTeksti());
        }
    }

}