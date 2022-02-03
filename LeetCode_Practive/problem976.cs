using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem976
    {
        public void Main976()
        {
            int[] nums = { 1, 5, 4, 6, 7, 8, 4, 3, 2, 4, 7, 5, 4, 2, 5, 6, 7, 8, 9, 4, 3, 2, 4, 5, 6, 32, 4353, 235, 62, 32, 31 };
            Console.WriteLine(LargestPerimeter(nums));
            Console.ReadKey();
        }
        public int LargestPerimeter(int[] nums)
        {
            //sort array
            Array.Sort(nums);
            //go through sorted array backwords
            for (int i = nums.Length - 3; i >= 0; i--)
            {
                //if a + b > c then we have a valid triangle, on first iteration
                //a = 3rd largest number, b = 2nd largest number, and c = largest number. 
                //loop until we satisfy a+b>c
                int a = nums[i], b = nums[i + 1], c = nums[i + 2];
                if (a + b > c)
                    return a + b + c;
            }
            return 0;
        }
    }
}
