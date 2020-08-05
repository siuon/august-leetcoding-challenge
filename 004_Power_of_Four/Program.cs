using System;

namespace _004_Power_of_Four
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given an integer (signed 32 bits), write a function to check whether it is a power of 4.

                Example 1:
                Input: 16
                Output: true
            */

            var num = 16;

            var solution = new Solution();

            Console.WriteLine(solution.IsPowerOfFour(num) == true);
        }
    }

    public class Solution
    {
        public bool IsPowerOfFour(int num)
        {
            throw new NotImplementedException();
        }
    }
}
