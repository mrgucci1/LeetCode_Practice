using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    internal class problem202
    {
        public void Main()
        {
            Console.WriteLine(IsHappy(19));
            Console.ReadKey();
        }
        static bool IsHappy(int n)
        {
            //hashmap to store every sum we calced
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            return happyHelper(n, hashMap);
        }
        static bool happyHelper(int n, Dictionary<int, int> hashMap)
        {
            //if our n = 1, we return true
            if (n == 1)
                return true;
            
            char[] nums = n.ToString().ToCharArray();
            int sum = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                int mult = Convert.ToInt32(nums[i].ToString());
                sum += mult * mult;
            }
            //if our haspmap contains this sum, means we have a loop, return false
            if (hashMap.ContainsKey(sum))
                return false;
            //add our calced sum to haspmap
            hashMap.Add(sum, 1);
            return happyHelper(sum, hashMap);
        }
    }
}
