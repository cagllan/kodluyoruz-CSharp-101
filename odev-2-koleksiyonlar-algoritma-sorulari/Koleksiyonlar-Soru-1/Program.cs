using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int number;
            int loopCount = 20;
            bool isNumber;
            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers= new ArrayList();
            
            int averagePrimeNumbers = 0;
            int averageNonPrimeNumbers = 0;

            Console.WriteLine("{0} adet pozitif sayı girin: ", loopCount);

            for(int i=0; i < loopCount ; i++)
            {
                Console.Write("{0}. sayıyı girin: ", i+1);

                isNumber = int.TryParse(Console.ReadLine(), out number);

                if( isNumber && number > 0)
                {
                    if(isPrimeNumber(number))
                    {
                        primeNumbers.Add(number);
                    }
                    else
                    {
                        nonPrimeNumbers.Add(number);
                    }
                }
                else
                {
                    i--;
                    Console.WriteLine("Lütfen pozitif sayı girin.");
                }
                

            }

            // prime numbers
            primeNumbers.Sort();
            primeNumbers.Reverse();

            foreach(var primeNumber in primeNumbers)
            {
                averagePrimeNumbers += Convert.ToInt32(primeNumber);
            }

            Console.WriteLine("-------------------- Asal Sayılar --------------------");
            Console.WriteLine("Asal sayıların büyükten küçüğe sıralama: " + String.Join(" ", primeNumbers.ToArray()));
            Console.WriteLine("Asal sayıların eleman sayısı: {0}", primeNumbers.Count);
            Console.WriteLine("Asal sayıların ortalaması: {0}", averagePrimeNumbers );
            Console.WriteLine("----------------------------------------------------------------------------");

            // non-prime numbers
            nonPrimeNumbers.Sort();
            nonPrimeNumbers.Reverse();

            foreach(var nonPrimeNumber in nonPrimeNumbers)
            {
                averageNonPrimeNumbers += Convert.ToInt32(nonPrimeNumber);
            }

            Console.WriteLine("-------------------- Asal Olmayan Sayılar --------------------");
            Console.WriteLine("Asal olmayan sayıların büyükten küçüğe sıralama: " + String.Join(" ", nonPrimeNumbers.ToArray()));
            Console.WriteLine("Asal olmayan sayıların sayısı: {0} ", nonPrimeNumbers.Count);
            Console.WriteLine("Asal olmayan sayıların ortalaması: {0}", averageNonPrimeNumbers );
            Console.WriteLine("----------------------------------------------------------------------------");

        }


        static bool isPrimeNumber(int checkNumber){
            bool flag = false;

            for (int i = 2; i < checkNumber/2 + 1 ; i++)
            {
                if (checkNumber % i == 0)
                    flag=true;
            }

            if (flag)
                return false;
            else
                return true;
            
        }
    }
}
