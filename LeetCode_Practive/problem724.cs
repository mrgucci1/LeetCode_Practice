using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem724
    {
        public void Main724()
        {
            //https://leetcode.com/problems/find-pivot-index/
            //help from
            //https://www.youtube.com/watch?v=u89i60lYx8U
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            Console.WriteLine(PivotIndex(nums));
            Console.ReadKey();

        }
        public int PivotIndex(int[] nums)
        {
            //leftsum starts as 0
            int leftSum = 0;
            //get sum of array 1 time
            int arraySum = nums.Sum();
            //loop through each index
            for (int i = 0; i < nums.Length; i++)
            {
                //Rightsum is equal to the total sum - left sum - current index
                int rightSum = arraySum - leftSum - nums[i];
                //if right sum = left sum then we found or pivot
                if (leftSum == rightSum)
                    return i;
                //incremement leftsum plus current index
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
