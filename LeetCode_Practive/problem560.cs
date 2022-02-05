using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem560
    {
        public void Main560()
        {
            int[] nums = { 1, 1, 1 };
            Console.WriteLine(SubarraySum(nums, 3));
            Console.ReadKey();
        }
        public int SubarraySum(int[] nums, int k)
        {
            //hold count of subarrays that equal k
            int subArrayCount = 0;
            //first for loop to serve as our starting position
            for (int i = 0; i < nums.Length; i++)
            {
                //set initial value for sum = start position in array
                int sum = nums[i];
                //incremement subarray count if the current sum already equals our desiered k
                if (sum == k)
                    subArrayCount++;
                //second for loop to check rest of the array (since there is negatives) for more subarrays equal to k
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k)
                        subArrayCount++;
                }
            }
            return subArrayCount;
        }
    }
}
