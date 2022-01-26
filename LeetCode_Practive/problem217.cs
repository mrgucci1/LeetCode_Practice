using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem217
    {
        public void Main217()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 1 };
            Console.WriteLine(ContainsDuplicate(nums).ToString());
            Console.ReadKey();
        }
        public bool ContainsDuplicate(int[] nums)
        {
            //use hashset to store nums, only contains unique numbers
            HashSet<int> hash = new HashSet<int>();
            foreach (int num in nums)
            {
                //before adding to hashset check if num already exists
                //if it does, we know we have a dupe so return true
                if (hash.Contains(num))
                    return true;
                hash.Add(num);
            }
            return false;
        }
    }
}
