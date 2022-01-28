using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem1304
    {
        public void Main1304(string[] args)
        {
            //https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/
            Console.WriteLine(SumZero(5));
            Console.ReadKey();

        }
        public int[] SumZero(int n)
        {
            List<int> ans = new List<int>();
            if (n % 2 == 0)
            {
                //even number
                for (int i = 0; i < n; i += 2)
                {
                    ans.Add((n - i) * -1); //add negative num
                    ans.Add(n - i); //add positive num
                }
            }
            else
            {
                //negative, add zero since we cant be perfect symetric with odd number
                //start array at 1 to ensure we dont add to much to array
                ans.Add(0);
                for (int i = 1; i < n; i += 2)
                {
                    ans.Add((n - i) * -1); //add negative num
                    ans.Add(n - i); //add positive num
                }
            }
            return ans.ToArray();
        }
    }
}
