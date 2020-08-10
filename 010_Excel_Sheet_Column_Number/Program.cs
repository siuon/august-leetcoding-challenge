using System.Linq;
using System;

namespace _010_Excel_Sheet_Column_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a column title as appear in an Excel sheet, return its corresponding column number.

                For example:
                    A -> 1
                    B -> 2
                    C -> 3
                    ...
                    Z -> 26
                    AA -> 27
                    AB -> 28 
                    ...

                Example 1:
                Input: "A"
                Output: 1

                Constraints:
                    1 <= s.length <= 7
                    s consists only of uppercase English letters.
                    s is between "A" and "FXSHRXW".
            */

            var s = "AA";

            var solution = new Solution();

            Console.WriteLine(solution.TitleToNumber(s) == 27);
        }
    }

    public class Solution
    {
        public int TitleToNumber(string s)
        {
            var sum = 0d;
            var i = 0;

            foreach (var ch in s.Reverse())
            {
                var num = (ch - 'A' + 1);

                sum += Math.Pow(26, i) * num;

                i++;
            }

            return Convert.ToInt32(sum);
        }
    }
}
