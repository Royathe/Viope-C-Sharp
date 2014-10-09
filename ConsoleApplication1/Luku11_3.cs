using System;

namespace ConsoleApplication1
{
    abstract class Elain
    {
        public abstract void Puhu();
    }




    // Sinun koodi tulee tähän
    interface IKaveleva
    {
        void Kavele();
    }
    interface IUiva
    {
        void Ui();
    }
    class Kissa : Elain , IKaveleva , IUiva 
    {
        public override void Puhu()
        {
            Console.WriteLine("Kissa sanoo miau");
        }
        void IKaveleva.Kavele()
        {
            Console.WriteLine("Kissa kävelee");
        }
        void IUiva.Ui()
        {
            Console.WriteLine("Kissa ui");
        }
    }


    class Ohjelma11_3
    {
        static void Run()
        {
            Elain kissa = new Kissa();

            ((IKaveleva)kissa).Kavele();
            ((IUiva)kissa).Ui();
            kissa.Puhu();
        }
    }
}