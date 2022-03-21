using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("----------Çalışan 1-------------");
            Calisan calisan1 = new Calisan("Mamoru", "Oshii", 23412237, "Animasyon");
            calisan1.CalisanBilgileri();

            System.Console.WriteLine("----------Çalışan 2-------------");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Atsuko";
            calisan2.Soyad = "Tanaka";
            calisan2.No = 56745689;
            calisan2.Departman = "Seslendirme";
            calisan2.CalisanBilgileri();

            System.Console.WriteLine("----------Çalışan 3-------------");
            Calisan calisan3 = new Calisan("Osamu", "Tezuka");            
            calisan3.CalisanBilgileri();

        }
    }


    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(){}


        public Calisan(string ad, string soyad)
        {            
            this.Ad = ad;
            this.Soyad = soyad;         
        }
        

        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Çalışanın Adı: {0}", Ad);
            System.Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            System.Console.WriteLine("Çalışanın Numarası: {0}", No);
            System.Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}

