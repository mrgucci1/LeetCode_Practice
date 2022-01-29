using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem3
    {
        public void Main3()
        {
            //https://leetcode.com/problems/longest-substring-without-repeating-characters
            Console.WriteLine(LengthOfLongest("bbtablud"));
            Console.ReadKey();
        }

        public int LengthOfLongest(string s)
        {
            int max = 0;
            if (s.Length > 0)
                max = 1;
            for (int i = 0; i < s.Length; i++)
            {
                HashSet<char> hashSet = new HashSet<char>();
                string compare = s[i].ToString();
                hashSet.Add(s[i]);
                for (int j = 1 + i; j < s.Length; j++)
                {
                    compare += s[j].ToString();
                    hashSet.Add(s[j]);
                    //if our compare = hashset, we know we have unique digits
                    if (compare.Length == hashSet.Count)
                    {
                        max = Math.Max(max, compare.Length);
                        continue;
                    }
                    //we do not have unique chars, break out of inner loop
                    break;
                }
            }
            return max;
        }
    }
}
