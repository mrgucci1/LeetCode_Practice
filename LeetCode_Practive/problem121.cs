using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem121
    {
        public void Main121()
        {
            //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
            int[] nums = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(nums));
            Console.ReadKey();
        }
        public int MaxProfit(int[] prices)
        {
            int buy = int.MaxValue;
            int sell = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                    buy = prices[i];
                if (prices[i] - buy > sell)
                    sell = prices[i] - buy;
            }
            if (sell < 0)
                return 0;
            return sell;
        }
    }
}
