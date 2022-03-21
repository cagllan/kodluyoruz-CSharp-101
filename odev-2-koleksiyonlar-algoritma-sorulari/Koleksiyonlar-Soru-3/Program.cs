using System;
using System.Collections;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] vowels = {'a', 'e','ı','i','o','ö','u','ü'};
            string sentence;
            List<string> vowelsInSentence = new List<string>();


            Console.WriteLine("Bir cümle girin:");
            sentence = Console.ReadLine();

            for(int i=0; i < sentence.Length;i++){
                if(vowels.Contains(sentence[i]))
                {
                    vowelsInSentence.Add(sentence[i].ToString());
                }
            }


            vowelsInSentence.Sort();
            
            foreach (var letter in vowelsInSentence)
            {
                Console.WriteLine(letter);
            }
        }

    }
}


