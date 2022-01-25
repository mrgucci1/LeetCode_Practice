using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem448
    {
        static void Main448(string[] args)
        {
            //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
            //help from
            //https://www.youtube.com/watch?v=8i-f24YFWC4
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            List<int> ans = FindDisappearedNumbers(nums);
            for (int i = 0; i < ans.Count(); i++)
            {
                Console.WriteLine(ans[i]);
            }
            Console.ReadKey();
        }
        static List<int> FindDisappearedNumbers(int[] nums)
        {
            //for O(n) and O(1) we modifiy given array by marking digts found with a negative
            //we mark the index with a negative but dont replace the value. so for EX:
            //if we find 4 in the array, we mark index 3(0-index) with negative. That means 4 exits. 
            //any index left postiive meants index + 1 is a disappeared number
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]);
                nums[index - 1] = Math.Abs(nums[index - 1]) * -1;
            }
            List<int> missingNum = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                //if postive, add to missingNum array
                if (nums[i] > 0)
                    missingNum.Add(i + 1);
            }
            return missingNum;
        }
    }
}
