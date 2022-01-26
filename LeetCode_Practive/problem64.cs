using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem64
    {
        public void Main64(string[] args)
        {
            //https://leetcode.com/problems/minimum-path-sum/
            //help from
            //https://leetcode.com/problems/minimum-path-sum/discuss/708708/Super-Easy-C-solution-with-explanation-beats-98
            //https://stackoverflow.com/questions/12567329/multidimensional-array-vs
            //jagged array
            int[][] grid = new int[3][];
            grid[0] = new int[] { 1, 3, 1 };
            grid[1] = new int[] { 1, 5, 1 };
            grid[2] = new int[] { 4, 2, 1 };
            Console.WriteLine(MinPathSum(grid));
        }
        public int MinPathSum(int[][] grid)
        {
            //loop down first row. We access the first element [0] of the i th array. since our loops start at 1
            //we take what our index is and add the one above to get cost.
            for (int i = 1; i < grid.Length; i++)
            {
                grid[i][0] += grid[i - 1][0];
            }
            //loop through the columns in first row. our first row is our first array, [0] and since our loop starts at 1
            // we add the cost of the num to left to current item.
            for (int j = 1; j < grid[0].Length; j++)
            {
                grid[0][j] += grid[0][j - 1];
            }
            //now we calc rest of array, we loop through starting at 1,1
            for (int i = 1; i < grid.Length; i++)
                for (int j = 1; j < grid[0].Length; j++)
                {
                    //set current grid position to the cost of the grid to left or above current index
                    grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
                }
            //return bottom right cost as it now contains the minimum cost to reach it!      
            return grid[grid.Length - 1][grid[0].Length - 1];
        }
    }
}
