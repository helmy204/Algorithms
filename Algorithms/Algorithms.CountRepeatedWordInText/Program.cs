using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.CountRepeatedWordInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hello world";
            string word = "hello";

            int count = CountOccurences(text, word);

            Console.WriteLine(count);
        }

        static int CountOccurences(string text, string word)
        {
            string[] textWords = text.Split(' ');
            int count = 0;

            foreach (string textWord in textWords)
            {
                if (word.Equals(textWord))
                    count++;
            }

            return count;
        }
    }
}
