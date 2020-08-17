using System;

namespace _015_Non_overlapping_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given a collection of intervals, 
                find the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping.

                Example 1:

                Input: [[1,2],[2,3],[3,4],[1,3]]
                Output: 1

                Explanation: [1,3] can be removed and the rest of intervals are non-overlapping.

                Note:
                    You may assume the interval's end point is always bigger than its start point.
                    Intervals like [1,2] and [2,3] have borders "touching" but they don't overlap each other.
            */

            var intervals = new int[4][];
            intervals[0] = new int[] { 1, 2 };
            intervals[1] = new int[] { 2, 3 };
            intervals[2] = new int[] { 3, 4 };
            intervals[3] = new int[] { 1, 3 };

            var solution = new Solution();

            Console.WriteLine(solution.EraseOverlapIntervals(intervals) == 1);
        }
    }

    public class Solution
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            throw new NotImplementedException();
        }
    }
}
