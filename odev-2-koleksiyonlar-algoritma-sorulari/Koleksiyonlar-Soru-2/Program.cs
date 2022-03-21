using System;
using System.Collections;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberCount = 20;
            int number;
            int[] numbers = new int[numberCount];

            bool state = true;
            bool isNumber;
            
            int max1, max2, max3;
            int min1, min2, min3;
            

            while (state)
            {
                System.Console.WriteLine(numberCount + " adet sayı girin");

                for (int i = 0; i < numberCount; i++)
                {
                    System.Console.Write(i + 1 + ". sayı: ");
                    isNumber = int.TryParse(Console.ReadLine(), out number);

                    if (isNumber)
                    {
                        numbers[i] = number;

                        if (i + 1 == numbers.Length)
                        {
                            state = false;
                        }
                    }
                    else
                    {
                        i--;
                        System.Console.WriteLine("Lütfen bir sayı girin!");
                    }

                }


            }

            // initial value assigment in max numbers
            max1 = numbers[0];
            max2 = numbers[1];
            max3 = numbers[2];

            // initial value assigment in min numbers
            min1 = numbers[0];
            min2 = numbers[1];
            min3 = numbers[2];

            // max numbers
            for (int j = 1; j < numbers.Length; j++)
                if (numbers[j] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = numbers[j];
                }
                else if (numbers[j] > max2)
                {
                    max3 = max2;
                    max2 = numbers[j];
                }

            // min numbers
            for (int k = 1; k < numbers.Length; k++)
                if (numbers[k] < min1)
                {
                    min3 = min2;
                    min2 = min1;
                    min1 = numbers[k];
                }
                else if (numbers[k] < min2)
                {
                    min3 = min2;
                    min2 = numbers[k];
                }

            //  average of min and max numbers
            int averageMaxNumbers = (max1 + max2 + max3) / 3;
            int averageMinNumbers = (min1 + min2 + min3) / 3;

            System.Console.WriteLine("---------- En Büyük Sayılar ---------");
            System.Console.WriteLine("en büyük 1. sayı: " + max1);
            System.Console.WriteLine("en büyük 2. sayı: " + max2);
            System.Console.WriteLine("en büyük 3. sayı: " + max3);

            System.Console.WriteLine("---------- En Küçük Sayılar ---------");
            System.Console.WriteLine("en küçük 1. sayı: " + min1);
            System.Console.WriteLine("en küçük 2. sayı: " + min2);
            System.Console.WriteLine("en küçük 3. sayı: " + min3);

            System.Console.WriteLine("---------- Sayıların Ortalaması ---------");
            System.Console.WriteLine("En büyük sayıların ortalaması: " + averageMaxNumbers);
            System.Console.WriteLine("En küçük sayıların ortalaması: " + averageMinNumbers);

            System.Console.WriteLine("---------- Ortalama Toplamı ---------");
            System.Console.WriteLine("En büyük ve en küçük sayıların ortalamalarının toplamı: " + (averageMaxNumbers + averageMinNumbers));
        }

    }
}

