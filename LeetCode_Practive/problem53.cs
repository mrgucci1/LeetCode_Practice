using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem53
    {
        public void Main53()
        {
            //https://leetcode.com/problems/maximum-subarray/
            //help from
            //https://www.youtube.com/watch?v=5WZl3MMT0Eg
            int[] nums = { -1, 0, -2 };
            Console.WriteLine(MaxSubArray(nums));
            Console.ReadKey();
        }
        public int MaxSubArray(int[] nums)
        {
            //max to store our max, set it to nums[0] since arry is nonempty and
            //cant set to zero since there is negative numbers
            int max = nums[0];
            int sum = 0;
            //loop through array
            for (int i = 0; i < nums.Length; i++)
            {
                //if our sum is less than zero, reset back to zero
                //this is the "sliding window" technique, we are basically ignore values with negative
                //prefixs and reseting or current subarray when a sum is less than zero
                if (sum < 0)
                    sum = 0;
                //add current index to sum
                sum += nums[i];
                //calc max as we go
                max = Math.Max(max, sum);
            }
            return max;
        }

    }
}
