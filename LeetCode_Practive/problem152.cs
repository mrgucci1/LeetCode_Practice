using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem152
    {
        public void Main152()
        {
            //https://leetcode.com/problems/maximum-product-subarray/
            //help from
            //https://www.youtube.com/watch?v=lXVy6YWFcRM
            //https://stackoverflow.com/questions/6800838/is-there-a-method-to-find-the-max-of-3-numbers-in-c
            int[] nums = { -4, -3, -2 };
            Console.WriteLine(MaxProduct(nums));
            Console.Read();
        }
        public int MaxProduct(int[] nums)
        {
            int result = nums.Max();
            int currMin = 1, currMax = 1;
            foreach (int num in nums)
            {
                int temp = currMax * num;
                currMax = Max(num * currMax, num * currMin, num);
                currMin = Min(temp, num * currMin, num);
                result = Max(result, currMax, currMin);
            }
            return result;
        }
        static int Max(params int[] numbers)
        {
            return numbers.Max();
        }
        static int Min(params int[] numbers)
        {
            return numbers.Min();
        }
    }
}
