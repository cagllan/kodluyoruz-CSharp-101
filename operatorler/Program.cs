using System;

namespace operatorler // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama

            Console.WriteLine("-------Atama ve işlemli atama operatorleri-------");

            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2; // işlemli atama

            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Mantıksal operatorler
            //  ||, &&, !

            Console.WriteLine("-------Mantıksal operatorler-------");

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            // ilişkisel operatorler
            // >, <, <=, >= , ==, !=

            Console.WriteLine("-------ilişkisel operatorler-------");
            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);

            // Aritmetik operatorler
            // /, * , +, -

            Console.WriteLine("-------Aritmetik operatorler-------");

            int sayi1 = 10;
            int sayi2= 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = ++sayi1;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1-sayi2;
            Console.WriteLine(sonuc1);


            // % , mod alma
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);



             
        }
    }
}

