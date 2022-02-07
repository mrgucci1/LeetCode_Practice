using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem367
    {
        public void Main367(string[] args)
        {
            //https://leetcode.com/problems/valid-perfect-square/
            Console.WriteLine(IsPerfectSquare(227));
            Console.ReadKey();
        }
        public bool IsPerfectSquare(int num)
        {
            //start at zero, count up until we either equal num or we are greater than num
            for (int i = 0; i < num + 1; i++)
            {
                if (i * i == num)
                    return true;
                else if (i * i > num)
                    return false;
            }
            return false;
        }
    }
    
}
