using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ready for my next problem Sire!");
            //Console.ReadKey();
            //https://leetcode.com/problems/decode-ways/
            Console.WriteLine(NumDecodings("226"));
            Console.ReadKey();

        }
        static int NumDecodings(string s)
        {
            int[] cache = Enumerable.Repeat(1, s.Length).ToArray();
            return dfs(0, cache, s);
        }
        static int dfs(int i, int[] cache, string s)
        {
            if (i == s.Length)
                return 1;
            if (cache.Contains(i))
                return cache[i];
            if (s[i] == '0')
                return 0;
            int result = dfs(i + 1, cache, s);
            if (i + 1 < s.Length && (s[i] == '1' || (s[i] == '2' && "0123456".Contains(s[i + 1].ToString()))))
                result += dfs(i + 2, cache, s);
            cache[i] = result;
            return result;
        }
    }
}

