using System;

namespace Algoritma_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words;

            Console.Write("Girilecek kelime adetini yazın: ");
            int number = int.Parse(Console.ReadLine());

            words = new string[number];


            for (int i = 0; i < number; i++)
            {
                Console.Write((i + 1) + ". kelime: ");
                words[i] = Console.ReadLine();
            }

            Array.Reverse(words);

            Console.WriteLine("Girdiğiniz kelimeler sondan başa doğru: ");

            foreach (var word in words)
            {
                Console.WriteLine(word);
                
            }
        }
    }
}

