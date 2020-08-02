using System;

namespace Detect_Capital
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a word, you need to judge whether the usage of capitals in it is right or not.

                We define the usage of capitals in a word to be right when one of the following cases holds:

                All letters in this word are capitals, like "USA".
                All letters in this word are not capitals, like "leetcode".
                Only the first letter in this word is capital, like "Google".
                Otherwise, we define that this word doesn't use capitals in a right way.
                

                Example 1:

                Input: "USA"
                Output: True
            */

            var word = "USA";

            var solution = new Solution();

            Console.WriteLine(solution.DetectCapitalUse(word) == true);
        }
    }

    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            var capitalCount = 0;

            foreach (var ch in word)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    capitalCount++;
                }
            }

            var isValid = false;

            if (capitalCount == word.Length)
            {
                isValid = true;
            }
            else if (capitalCount == 0)
            {
                isValid = true;
            }
            else if (capitalCount == 1 &&
                     (word[0] >= 'A' && word[0] <= 'Z'))
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
