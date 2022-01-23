using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem1578
    {
        static void Main1579(string[] args)
        {
            //https://leetcode.com/problems/minimum-time-to-make-rope-colorful/
            string colors = "bbbaaa";
            int[] neededTime = { 4, 9, 3, 8, 8, 9 };
            Console.WriteLine(MinCost(colors, neededTime));
            Console.ReadKey();
        }
        static public int MinCost(string colors, int[] neededTime)
        {

            int result = 0, max_cost = 0, sum_cost = 0;
            for (int i = 0; i < colors.Length; i++)
            {
                if (i > 0 && colors[i] != colors[i - 1])
                {
                    result += sum_cost - max_cost;
                    sum_cost = max_cost = 0;
                }
                sum_cost += neededTime[i];
                max_cost = Math.Max(max_cost, neededTime[i]);

            }
            return (result += sum_cost - max_cost);
        }
    }
}
