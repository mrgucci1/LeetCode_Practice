using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem283
    {
        public void Main283()
        {
            //https://leetcode.com/problems/move-zeroes/
            //help from
            //https://www.youtube.com/watch?v=aayNRwUN3Do
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
            //since our array was modified in memory, we print our modified array and zeros will be on the right since we
            //swapped every non zero number to the left
            foreach (int num in nums)
                Console.WriteLine(num);
            Console.ReadKey();
        }
        public void MoveZeroes(int[] nums)
        {
            //left pointer to store index of value we will need to swap
            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                //we ignore zeros, for each number we swap it with out left index
                if (nums[i] != 0)
                {
                    //temp int to store left pointer value
                    int temp = nums[left];
                    //swap left with current index in loop
                    nums[left] = nums[i];
                    nums[i] = temp;
                    //increment left
                    left++;

                }
            }
        }
    }
}
