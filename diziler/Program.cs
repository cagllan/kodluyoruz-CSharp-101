﻿using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi", "köpek", "kuş", "maymun"};
            int[] dizi;
            dizi = new int[5];

            // Dizilere değer atama ve erişim
            renkler[0] = "mavi";
            dizi[3] = 10;

            System.Console.WriteLine(hayvanlar[1]);
            System.Console.WriteLine(dizi[3]);            
            System.Console.WriteLine(renkler[0]);

            // Döngülerle dizi kullanımı

            // Klavyeden girilen n tane sayının ortalamasını alan program

            System.Console.Write("Lütfen dizinin eleman sayısını giriniz: ");

            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                System.Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
                toplam += sayi;

            System.Console.WriteLine("Ortalama:" + toplam/diziUzunlugu);
        }
    }
}
