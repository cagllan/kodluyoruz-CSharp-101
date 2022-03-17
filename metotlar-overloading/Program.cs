using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            // out parametreler

            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);


            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }


            Metotlar instanceMethotlar = new Metotlar();
            instanceMethotlar.Topla(2, 3, out int toplamaSonucu);
            Console.WriteLine(toplamaSonucu);

            // Metot Overloading - Metot aşırı yükleme

            int ifade = 999;

            instanceMethotlar.EkranaYazdir(Convert.ToString(ifade));
            instanceMethotlar.EkranaYazdir(ifade);
            instanceMethotlar.EkranaYazdir("Caglan", "Atay");

        }

    }


    class Metotlar
    {

        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }

}



