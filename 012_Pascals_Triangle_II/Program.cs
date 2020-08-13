using System;

namespace _012_Pascals_Triangle_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.

                Note that the row index starts from 0.

                In Pascal's triangle, each number is the sum of the two numbers directly above it.

                Example:
                Input: 3
                Output: [1,3,3,1]

                Follow up:
                    Could you optimize your algorithm to use only O(k) extra space?
            */

            var rowIndex = 3;

            var solution = new Solution();

            var result = solution.GetRow(rowIndex);
        }
    }

    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            throw new NotImplementedException();
        }
    }
}
