using System;

namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFocus focus1 = new NewFocus();
            System.Console.WriteLine(focus1.HangiMarkaninAraci().ToString());
            System.Console.WriteLine(focus1.KacTekerlektenOlusur());
            System.Console.WriteLine(focus1.StandartRengiNe().ToString());

            System.Console.WriteLine("----------------------------------------------------");

            NewCivic civic1 = new NewCivic();
            System.Console.WriteLine(civic1.HangiMarkaninAraci().ToString());
            System.Console.WriteLine(civic1.KacTekerlektenOlusur());
            System.Console.WriteLine(civic1.StandartRengiNe().ToString());
        }
    }
}
