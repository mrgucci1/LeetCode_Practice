using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem532
    {
        public void Main532()
        {
            //https://leetcode.com/problems/k-diff-pairs-in-an-array/
            int[] nums = { 1, 3, 1, 5, 4 };
            Console.WriteLine(FindPairs(nums, 0));
            Console.ReadKey();
        }
        public int FindPairs(int[] nums, int k)
        {
            //hashset to store unique pairs
            HashSet<string> hashSet = new HashSet<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    //check our condition to add to array
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        if (!hashSet.Contains((nums[i] + nums[j]).ToString()) || !hashSet.Contains((nums[j] + nums[i]).ToString()))
                            hashSet.Add((nums[i] + nums[j]).ToString());
                    }
                }
            }
            return hashSet.Count();
        }
    }
}
