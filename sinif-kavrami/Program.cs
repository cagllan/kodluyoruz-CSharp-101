using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Mamoru";
            calisan1.Soyad = "Oshii";
            calisan1.No = 23412237;
            calisan1.Departman = "Animasyon";

            calisan1.CalisanBilgileri();

            System.Console.WriteLine("---------------------------------");

             Calisan calisan2 = new Calisan();
            calisan2.Ad = "Atsuko";
            calisan2.Soyad = "Tanaka";
            calisan2.No = 56745689;
            calisan2.Departman = "Seslendirme";

            calisan2.CalisanBilgileri();

        }
    }


    class Calisan
    {

        public string Ad;
        public string Soyad;
        public int No;
        public string  Departman;

        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Çalışanın Adı: {0}", Ad);
            System.Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            System.Console.WriteLine("Çalışanın Numarası: {0}", No);
            System.Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}

