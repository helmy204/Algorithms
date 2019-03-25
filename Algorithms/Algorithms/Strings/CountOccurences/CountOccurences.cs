using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.CountRepeatedWordInText
{
    public class CountOccurences
    {
        public static int CountOccurences_1(string text, string word)
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
