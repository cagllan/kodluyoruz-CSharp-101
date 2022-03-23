using System;

namespace polymorphism
{    
    public class Hayvanlar:Canlilar
    {
         protected void Adaptasyon()
        {
            System.Console.WriteLine("Hayvanlar adaptaston kurabilir.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            System.Console.WriteLine("Hayvanlar temasa tepki verir.");
        }

    }


    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SurunerekHareketEtmek()
        {
            System.Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }


    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }

        public void Ucmak()
        {
            System.Console.WriteLine("Kuşlar uçar.");
        }
    }
}