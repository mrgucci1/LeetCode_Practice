using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem1758
    {
        public void Main1758()
        {
            //https://leetcode.com/problems/minimum-changes-to-make-alternating-binary-string/
            Console.WriteLine(MinOperations("10010100"));
            Console.ReadKey();
        }
        static int MinOperations(string s)
        {
            //call calc alts twice, first time setting the prev to inverse of itself, and then as itself. 
            return Math.Min(calcAlts(s, 1, s[0] == '0' ? '1' : '0'), calcAlts(s, 0, s[0]));
        }
        static int calcAlts(string s, int count, char prev)
        {
            //loop through array starting at 1, our prev value hold the first value in array
            for (int i = 1; i < s.Length; i++)
            {
                //if prev is equal to current index
                if (prev == s[i])
                {
                    //incremenet count, because we have to switch current index
                    count++;
                    //set prev to the inverse of current index
                    prev = s[i] == '0' ? '1' : '0';
                    //cont loop
                    continue;
                }
                //set prev to current index if they are not same char
                prev = s[i];
            }
            return count;
        }
    }
}
