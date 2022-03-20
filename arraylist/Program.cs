using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // System.Collection namespace
            ArrayList liste= new ArrayList();

            // eleman atama
            liste.Add("Henry");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            // içerisindeki verilere erişim
            System.Console.WriteLine(liste[1]);

            foreach (var item in liste)
                System.Console.WriteLine(item);

            // AddRange 
            System.Console.WriteLine("-----------Add Range-----------");

            
            string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
            List<int> sayilar = new List<int>(){1, 8, 3, 7, 9, 92, 5};

            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                System.Console.WriteLine(item);

            // new ArrayList
            ArrayList liste2= new ArrayList(){1, 8, 3, 7, 9, 92, 5, 42};

            // Sort 
            System.Console.WriteLine("-----------Sort-----------");
            // liste.Sort(); // <-- hata
            liste2.Sort();  

            foreach (var item in liste2)
                System.Console.WriteLine(item);

            // Binary Search
            System.Console.WriteLine("-----------Binary Search-----------");

            System.Console.WriteLine(liste2.BinarySearch(9));

            // Reverse
            System.Console.WriteLine("-----------Reverse-----------");

            liste2.Reverse();

            foreach (var item in liste2)
                System.Console.WriteLine(item);

            // Clear
            System.Console.WriteLine("-----------Clear-----------");
            liste2.Clear();

            foreach (var item in liste2)
                System.Console.WriteLine(item);
        }

    }

}



