using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    internal class problem39
    {
        public void Main39()
        {
            //https://leetcode.com/problems/combination-sum/
            //help from
            //https://www.youtube.com/watch?v=GBKI9VSKdGg
            int[] nums = { 1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            CombinationSum(nums, 10);
            Console.ReadLine();
        }
        List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            //call dfs for first time setting i = 0, passing in empty list, and 0 for total
            dfs(0, new List<int>(), 0, target, candidates);
            return result;
        }
        public void dfs(int i, List<int> current, int total, int target, int[] candidates)
        {
            //define base cases
            if (total == target)
            {
                result.Add(new List<int>(current));
                return;
            }
            //if our number is out of bounds or our total is greater than target we dont want to 
            //calc further
            if (i >= candidates.Length || total > target)
                return;
            //add current candidate to currnt array
            current.Add(candidates[i]);
            //call dfs to see if we added itself again if we result in a valid combination
            dfs(i, current, total + candidates[i], target, candidates);
            //remove last addition to current so we can call dfs with
            //the next value in candidates
            current.RemoveAt(current.Count - 1);
            dfs(i + 1, current, total, target, candidates);
        }
    }
}
