using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    internal class problem2034
    {
        public void Main2034()
        {
            //https://leetcode.com/problems/stock-price-fluctuation/
            //help from
            //https://leetcode.com/problems/stock-price-fluctuation/discuss/1779531/C-faster-than-100-Dictionary-SortedSet
            StockPrice obj = new StockPrice();
            obj.Update(2, 10);
            obj.Update(3, 20);
            obj.Update(1, 5);
            obj.Update(2, 10);
            obj.Update(10, 100);
            int param_2 = obj.Current();
            int param_3 = obj.Maximum();
            int param_4 = obj.Minimum();
        }
    }
    public class StockPrice
    {
        //dictionary to store timestamps and price
        Dictionary<int, int> stockPrice;
        //sorted set to store our max price at timestamps
        SortedSet<(int Price, int Timestamp)> sortedPrice;
        //int to track most current timestamp
        int currentTimestamp;

        public StockPrice()
        {
            stockPrice = new Dictionary<int, int>();
            sortedPrice = new SortedSet<(int Price, int Timestamp)>();
        }

        public void Update(int timestamp, int price)
        {
            //update current timestamp
            currentTimestamp = Math.Max(currentTimestamp, timestamp);
            //if we do not have this in our hashmap, add
            if (!stockPrice.ContainsKey(timestamp))
            {
                sortedPrice.Add((price, timestamp));
                stockPrice.Add(timestamp, price);
                return;
            }
            else
            {
                //if we already have this, means the price changed. Need to update sorted set
                //by removing and then adding
                sortedPrice.Remove((stockPrice[timestamp], timestamp));
                sortedPrice.Add((price, timestamp));
                stockPrice[timestamp] = price;
            }

        }

        public int Current()
        {
            return stockPrice[currentTimestamp];
        }

        public int Maximum()
        {
            return sortedPrice.Max.Price;
        }

        public int Minimum()
        {
            return sortedPrice.Min.Price;
        }
    }
}
