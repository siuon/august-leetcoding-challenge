using System;
using System.Collections.Generic;

namespace _019_Goat_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                A sentence S is given, composed of words separated by spaces. Each word consists of lowercase and uppercase letters only.

                We would like to convert the sentence to "Goat Latin" (a made-up language similar to Pig Latin.)

                The rules of Goat Latin are as follows:

                If a word begins with a vowel (a, e, i, o, or u), append "ma" to the end of the word.
                For example, the word 'apple' becomes 'applema'.
                
                If a word begins with a consonant (i.e. not a vowel), remove the first letter and append it to the end, then add "ma".
                For example, the word "goat" becomes "oatgma".
                
                Add one letter 'a' to the end of each word per its word index in the sentence, starting with 1.
                For example, the first word gets "a" added to the end, the second word gets "aa" added to the end and so on.
                Return the final sentence representing the conversion from S to Goat Latin. 

                Example 1:
                Input: "I speak Goat Latin"
                Output: "Imaa peaksmaaa oatGmaaaa atinLmaaaaa"

                Notes:

                    S contains only uppercase, lowercase and spaces. Exactly one space between each word.
                    1 <= S.length <= 150.
            */

            var S = "I speak Goat Latin";

            var solution = new Solution();

            Console.WriteLine(solution.ToGoatLatin(S) == "Imaa peaksmaaa oatGmaaaa atinLmaaaaa");
        }
    }

    public class Solution
    {
        public string ToGoatLatin(string S)
        {
            var returnValue = new List<string>();
            var tempSList = S.Split(' ');
            var vowel = "aeiouAEIOU";
            var tempWord = string.Empty;
            var currentWord = string.Empty;

            for (var i = 0; i < tempSList.Length; i++)
            {
                tempWord = string.Empty;
                currentWord = tempSList[i];

                if (vowel.Contains(currentWord[0]))
                {
                    tempWord = currentWord;
                }
                else
                {
                    tempWord = currentWord.Substring(1) + currentWord[0];
                }

                tempWord += "ma" + Get_a(i + 1);

                returnValue.Add(tempWord);
            }

            return string.Join(' ', returnValue);
        }

        private string Get_a(int length)
        {
            var returnValue = string.Empty;

            for (int i = 0; i < length; i++)
            {
                returnValue += 'a';
            }

            return returnValue;
        }
    }
}
