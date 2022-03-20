using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collection.Generic
            // <key, value>
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            // eleman ekleme
            kullanicilar.Add(10, "Henry Cavil");
            kullanicilar.Add(12, "Takeshi Kitano");
            kullanicilar.Add(18, "Anna Torv");
            kullanicilar.Add(20, "Hugh Laurie");

            // Dizinin elemanlarına erişim
            Console.WriteLine("--------Elemanlara Erişim--------");
            Console.WriteLine(kullanicilar[12]);

            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //Count
            Console.WriteLine("--------Count--------");
            Console.WriteLine(kullanicilar.Count);

            // Contains
            Console.WriteLine("--------Contains--------");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Michael C. Hall"));

            // Remove
            Console.WriteLine("--------Remove--------");
            kullanicilar.Remove(12);

            foreach (var item in kullanicilar)
                Console.WriteLine(item);
    

            // Keys
            Console.WriteLine("--------Keys--------");
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);

            // Values
            Console.WriteLine("--------Values--------");
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);

            
        }
    }
}
