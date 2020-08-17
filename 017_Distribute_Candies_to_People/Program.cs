using System;

namespace _017_Distribute_Candies_to_People
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                We distribute some number of candies, to a row of n = num_people people in the following way:

                We then give 1 candy to the first person, 2 candies to the second person, and so on until we give n candies to the last person.

                Then, we go back to the start of the row, giving n + 1 candies to the first person, 
                n + 2 candies to the second person, and so on until we give 2 * n candies to the last person.

                This process repeats (with us giving one more candy each time, 
                and moving to the start of the row after we reach the end) until we run out of candies.  
                The last person will receive all of our remaining candies (not necessarily one more than the previous gift).

                Return an array (of length num_people and sum candies) that represents the final distribution of candies.

                Example 1:

                Input: candies = 7, num_people = 4
                Output: [1,2,3,1]
            
                Explanation:
                On the first turn, ans[0] += 1, and the array is [1,0,0,0].
                On the second turn, ans[1] += 2, and the array is [1,2,0,0].
                On the third turn, ans[2] += 3, and the array is [1,2,3,0].
                On the fourth turn, ans[3] += 1 (because there is only one candy left), and the final array is [1,2,3,1].

                Constraints:
                    1 <= candies <= 10^9
                    1 <= num_people <= 1000
            */

            var candies = 10;
            var num_people = 3;

            var solution = new Solution();

            solution.DistributeCandies(candies, num_people);
        }
    }

    public class Solution
    {
        public int[] DistributeCandies(int candies, int num_people)
        {
            var count = 1;
            var returnValue = new int[num_people];

            while (candies > 0)
            {
                for (int i = 0; i < num_people; i++)
                {
                    returnValue[i % num_people] = candies >= count ? count : candies;

                    candies -= count;

                    if (candies <= 0)
                    {
                        break;
                    }
                    
                    count++;
                }

            }

            return returnValue;
        }
    }
}
