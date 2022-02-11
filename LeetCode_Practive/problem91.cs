using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    internal class problem91
    {
        public void Main91()
        {
            //https://leetcode.com/problems/decode-ways/
            //help from
            //https://leetcode.com/problems/decode-ways/discuss/497680/Accepted-C-(DP)-solution%3A-Easy-to-understand
            //https://www.youtube.com/watch?v=6aEyTjOwlJU
            Console.WriteLine(NumDecodings("226"));
            Console.ReadKey();
        }
        public int NumDecodings(string s)
        {
            if (s == null || s.Length == 0 || s[0] == '0')
                return 0;

            int n = s.Length;
            //create int array to hold calculations
            int[] dp = new int[n + 1];

            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                //set num1 to index - 1, num2 to index - 2
                //we will use these to see if we have a valid pair
                //and check for zeros
                int num1 = int.Parse(s.Substring(i - 1, 1));
                int num2 = int.Parse(s.Substring(i - 2, 2));
                //is num1 > 0, if it is c1 is valid
                int c1 = num1 > 0 ? dp[i - 1] : 0;
                //is num2 >= 10 and is it less than 26. since we have 2 digts here we are checking
                //the 10-26 range
                int c2 = num2 >= 10 && num2 <= 26 ? dp[i - 2] : 0;
                //add our calculations to the dp array
                dp[i] = c1 + c2;
            }
            //return last index
            return dp[n];
        }
    }
}
