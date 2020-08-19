using System;

namespace _018_Numbers_With_Same_Consecutive_Differences
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Return all non-negative integers of length N such that the absolute difference between every two consecutive digits is K.

                Note that every number in the answer must not have leading zeros except for the number 0 itself. For example, 
                01 has one leading zero and is invalid, but 0 is valid.

                You may return the answer in any order.

                Example 1:
                Input: N = 3, K = 7
                Output: [181,292,707,818,929]

                Explanation: Note that 070 is not a valid number, because it has leading zeroes.

                Note:
                    1 <= N <= 9
                    0 <= K <= 9
            */

            var N = 3;
            var K = 7;

            var solution = new Solution();

            solution.NumsSameConsecDiff(N, K);
        }
    }

    public class Solution
    {
        public int[] NumsSameConsecDiff(int N, int K)
        {
            throw new NotImplementedException();
        }
    }
}
