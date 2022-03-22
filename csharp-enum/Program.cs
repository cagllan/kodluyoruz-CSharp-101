using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);
            System.Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
            if(sicaklik <= (int)HavaDurumu.Normal)
                System.Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            else if (sicaklik >= (int)HavaDurumu.Sıcak)
                System.Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
                System.Console.WriteLine("Hadi dışarıya çıkalım");            
        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSicak = 30
    }
}

