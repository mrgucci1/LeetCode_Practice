using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    internal class problem56
    {
        public void Main56()
        {
            //https://leetcode.com/problems/merge-intervals/
            //help from
            //https://leetcode.com/problems/merge-intervals/discuss/1305131/C
            //https://docs.google.com/spreadsheets/d/1A2PaQKcdwO_lwxz9bAnxXnIQayCouZP6d-ENrBz_NXc/edit#gid=0
            int[][] grid = new int[3][];
            grid[0] = new int[] { 4, 10 };
            grid[1] = new int[] { 1, 5 };
            grid[2] = new int[] { 1, 3 };
            grid = Merge(grid);
            foreach (int[] row in grid)
                Console.WriteLine($"{row[0]}, {row[1]}");
            Console.ReadKey();
        }
        public int[][] Merge(int[][] intervals)
        {

            if (intervals == null || intervals.Length == 0)
                return new int[0][];
            //sort intervals on the beginning time
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
            //list of int arrays to store result, need list because its dynamic
            List<int[]> result = new List<int[]>();
            //store first start and end
            int start = intervals[0][0];
            int end = intervals[0][1];
            //loop starting at second interval
            for (int i = 1; i < intervals.Length; i++)
            {
                //if this intervals start time is less than or equal to current end
                //update end to the max of end or current interval end, contuine loop until
                //we find one that doesnt over lap
                if (intervals[i][0] <= end)
                {
                    end = Math.Max(end, intervals[i][1]);
                    continue;
                }
                //add result once it no longer overlaps
                result.Add(new int[] { start, end });
                //update start and end intervals
                start = intervals[i][0];
                end = Math.Max(intervals[i][1], end);
            }
            //add last result to list
            result.Add(new int[] { start, end });
            return result.ToArray();
        }
    }
}
