using System;

namespace inheritance 
{
    class Program
    {
        static void Main(string[] args)
        {

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            System.Console.WriteLine("----------------------------------");

            Kuslar marti = new Kuslar();
            marti.Ucmak();

        }
    }
}

