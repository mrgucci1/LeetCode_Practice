using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    internal class problem374
    {
        public void Main374()
        {
            //https://leetcode.com/problems/guess-number-higher-or-lower/
            //collab with will taylor to solve together!
            Console.WriteLine(GuessNumber(2147483647));
            Console.ReadKey();
        }
        public int GuessNumber(int n)
        {
            //setup min, max and initial guess value = to half of max
            int min = 1, max = n, num = n / 2;
            //store result from guess in result int
            int result = guess(num);
            //while our result != 0, meaing we having found the picked number
            while (result != 0)
            {
                //if our guessed number is lower that actual, update min to previous guess plus one
                if (result == 1)
                    min = num + 1;
                //if our guessed number is higher than actual, update max to previous guess minus one
                if (result == -1)
                    max = num - 1;
                //update our guessed to midpoint between min and max
                num = min + (max - min) / 2;
                result = guess(num);
            }
            return num;
        }
        public int guess(int num)
        {
            int pick = 2147483647;
            if (num > pick)
                return -1;
            if (num < pick)
                return 1;
            else
                return 0;
        }
    }
}
