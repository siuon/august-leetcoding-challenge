using System.Linq;
using System;
using System.Collections.Generic;

namespace _006_Find_All_Duplicates_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
                Find all the elements that appear twice in this array.

                Could you do it without extra space and in O(n) runtime?

                Example:
                Input:
                [4,3,2,7,8,2,3,1]
                Output:
                [2,3]
            */

            var nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };

            var solution = new Solution();

            solution.FindDuplicates(nums);
        }
    }

    public class Solution
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var list = new Dictionary<int, int>();
            var returnList = new List<int>();

            foreach (var num in nums)
            {
                if (list.ContainsKey(num))
                {
                    list[num] ^= num;
                }
                else
                {
                    list.Add(num, num);
                }

                if (list[num] == 0)
                {
                    returnList.Add(num);
                }
                else
                {
                    returnList.Remove(num);
                }
            }

            return returnList;
        }
    }
}
