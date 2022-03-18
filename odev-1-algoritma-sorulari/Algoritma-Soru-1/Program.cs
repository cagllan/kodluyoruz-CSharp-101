using System;

namespace Algoritma_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers;

            Console.Write("Girilecek sayı adetini yazın: ");

            int number = int.Parse(Console.ReadLine());

            numbers = new int[number];


            for (int i = 0; i < number; i++)
            {
                Console.Write((i + 1) + ". sayı: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine("çift sayı: " + item + " ");
                }
                
            }
        }
    }
}
