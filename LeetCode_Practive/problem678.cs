using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem678
    {
        public void Main678()
        {
            //https://leetcode.com/problems/valid-parenthesis-string/
            //help from
            //https://leetcode.com/problems/valid-parenthesis-string/solution/
            //https://www.youtube.com/watch?v=QhPdNS143Qg&t=589s
            Console.WriteLine(CheckValidString("(*))"));
            Console.ReadKey();
        }
        public bool CheckValidString(string s)
        {
            int low = 0, high = 0;
            foreach (char c in s)
            {
                //if current c is open bracket, add to low
                if (c == '(')
                    low++;
                else
                    low--; //if its close bracket or wildcard, remove from low
                if (c != ')') //if open or wild, add to high
                    high++;
                else
                    high--; //if it is a closing, remove from high
                if (high < 0) //if high is ever less than zero, break 
                    break;
                low = Math.Max(low, 0); //make sure low doesnt fall below 0, because of wildcards string can still be valid with lower than zero low
            }
            return low == 0;
        }
    }
}
