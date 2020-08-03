using System.Linq;
using System;
using System.Collections.Generic;

namespace _003_Valid_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

                Note: For the purpose of this problem, we define empty string as valid palindrome.

                Example 1:
                Input: "A man, a plan, a canal: Panama"
                Output: true

                Constraints:
                s consists only of printable ASCII characters.
            */

            var s = "race a car";

            var solution = new Solution();

            Console.WriteLine(solution.IsPalindrome(s) == false);
        }
    }

    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var oriList = new List<char>();

            foreach (var ch in s)
            {
                if ((ch >= '0' && ch <= '9') ||
                    (ch >= 'a' && ch <= 'z') ||
                    (ch >= 'A' && ch <= 'Z'))
                {
                    oriList.Add(ch);
                }
            }

            var reverse = oriList.ToList();

            reverse.Reverse();

            return new String(oriList.ToArray()).ToLower() == new String(reverse.ToArray()).ToLower();
        }
    }
}
