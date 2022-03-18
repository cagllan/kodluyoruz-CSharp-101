using System;

namespace Algoritma_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers;

            Console.Write("Girilecek sayı adetini yazın: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Kontrol edilecek sayıyı girin: ");
            int checkNumber = int.Parse(Console.ReadLine());

            numbers = new int[number];


            for (int i = 0; i < number; i++)
            {
                Console.Write((i + 1) + ". sayı: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            foreach (var item in numbers)
            {
                if (item == checkNumber)
                {
                    Console.WriteLine( "{0} sayısı {1} sayısına eşit .",checkNumber, item);
                }
                else if(item % checkNumber == 0)
                {
                    Console.WriteLine( "{1} sayısı {0} sayısına tam bölünüyor.",checkNumber, item);
                }
                
            }
        }
    }
}
