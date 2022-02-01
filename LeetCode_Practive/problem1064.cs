using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem1064
    {
        public void Main1064()
        {
            //https://leetcode.com/problems/fixed-point/
            int[] nums = { -10, -5, 0, 3, 7 };
            Console.WriteLine(FixedPoint(nums));
            Console.ReadKey();
        }
        public int FixedPoint(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == i)
                    return i;
            return -1;
        }
    }
}
