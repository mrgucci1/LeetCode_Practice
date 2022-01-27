using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem1189
    {
        public void Main1189()
        {
            //https://leetcode.com/problems/maximum-number-of-balloons/
            //help from
            //https://www.youtube.com/watch?v=G9xeB2-7PqY
            Console.WriteLine(MaxNumberOfBallons("nlaebolko"));
            Console.ReadKey();
        }
        public int MaxNumberOfBallons(string text)
        {
            Dictionary<char, int> counterHashMap = new Dictionary<char, int>();
            Dictionary<char, int> ballonHash = new Dictionary<char, int>();
            int result = text.Length;
            //initialize counterhasmap with given text
            foreach (char c in text)
            {
                if (counterHashMap.ContainsKey(c))
                    counterHashMap[c]++;
                else
                    counterHashMap.Add(c, 1);
            }
            //initailize ballonhash with string ballon
            string bal = "balloon";
            foreach (char c in bal)
            {
                if (ballonHash.ContainsKey(c))
                    ballonHash[c]++;
                else
                    ballonHash.Add(c, 1);
            }
            //loop through ballon text and take the min of occurance of letter in given string
            //versus how many of that letter we need to make the word balloon
            foreach (char c in "balloon")
            {
                //if given text does not contain a key we need to construct word balloon, return 0
                if (!(counterHashMap.ContainsKey(c)))
                    return 0;
                result = Math.Min(result, counterHashMap[c] / ballonHash[c]);
            }
            return result;
        }
    }
}
