using System;

namespace inheritance
{
    public class Hayvanlar:Canlilar
    {
         protected void Adaptasyon()
        {
            System.Console.WriteLine("Hayvanlar adaptaston kurabilir.");
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


        }
        public void Ucmak()
        {
            System.Console.WriteLine("Kuşlar uçar.");
        }
    }
}