using System;

namespace Algoritma_Soru_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence;
            string[] words;
            string[] newWords;
            int wordNumber = 1;
            bool isLengthSentenceZero = true;


            while (isLengthSentenceZero)
            {

                Console.WriteLine("Bir cümle yazın: ");
                sentence = Console.ReadLine().Trim();

                if (sentence.Length != 0)
                {

                    isLengthSentenceZero = false;

                    if (CheckSpaces(sentence))
                    {
                        int sentenceLength = RemoveWhiteSpaces(sentence).Length;
                        Console.WriteLine("Cümle içindeki toplam harf sayısı: " + sentenceLength);

                        newWords = sentence.Split(' ');
                        Console.WriteLine("Cümle içindeki toplam kelime sayısı: " + newWords.Length);
                    }
                    else
                    {
                        Console.WriteLine("Cümle içindeki toplam harf sayısı: " + sentence.Length);
                        Console.WriteLine("Cümle içindeki toplam harf sayısı: " + wordNumber);
                    }

                }

            }

        }


        public static bool CheckSpaces(string param)
        {
            return param.Contains(" ");
        }


        public static string RemoveWhiteSpaces(string param)
        {
            string[] stringArray = param.Split(" ");
            return string.Join("", stringArray);
        }
    }
}

