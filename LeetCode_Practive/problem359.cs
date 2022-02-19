using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    internal class problem359
    {
        public void Main359()
        {
            //https://leetcode.com/problems/logger-rate-limiter/
            Logger obj = new Logger();
            bool param_1 = obj.ShouldPrintMessage(3, "foo");
            bool param_2 = obj.ShouldPrintMessage(7, "foo");
            Console.WriteLine($"param-1: {param_1} param-2: {param_2}");
            Console.ReadKey();
        }

    }
    class Logger
    {
        Dictionary<string, int> map;
        public Logger()
        {
            map = new Dictionary<string, int>();
        }

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            //if our hashmap contains this message
            if (map.ContainsKey(message))
            {
                //check to see if its been 10 seconds, we add 10 seconds already when we add to hashmap
                if (timestamp > map[message])
                {
                    //update hashmap with new timestamp
                    map[message] = timestamp + 10;
                    return true;
                }
                else
                    return false;
            }
            else
            {
                //add to hashmap, add 10 seconds
                map.Add(message, timestamp + 10);
                return true;
            }
        }
    }
}
