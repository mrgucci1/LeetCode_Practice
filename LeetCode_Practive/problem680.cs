using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem680
    {
        public void Main680()
        {
            //https://leetcode.com/problems/valid-palindrome-ii/
            //colaborated with Will Taylor for solution,
            //Will update with better implementation, for now we have slow answer
            Console.WriteLine(ValidPalindrome("eedede"));
            Console.ReadKey();
        }
        public bool ValidPalindrome(string s)
        {
            List<char> charList = s.ToList<char>();
            int remove = 0;
            for (int i = 0; i < charList.Count(); i++)
            {
                if (charList[i] == charList[charList.Count() - 1 - i])
                {
                    charList.RemoveAt(i);
                    charList.RemoveAt(charList.Count() - 1 - i);
                    i--;
                }
                else
                {
                    remove++;
                    List<char> tempCharFront = new List<char>(charList);
                    List<char> tempCharBack = new List<char>(charList);
                    tempCharFront.RemoveAt(i);
                    tempCharBack.RemoveAt(charList.Count() - 1 - i);
                    return (helpPlaindrome(tempCharFront) || helpPlaindrome(tempCharBack));

                }
                if (charList.Count() <= 2 && remove == 0)
                    return true;
            }
            return true;
        }

        public bool helpPlaindrome(List<char> charList)
        {
            for (int j = 0; j < charList.Count(); j++)
            {
                if (charList[j] == charList[charList.Count() - 1 - j])
                {
                    continue;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
