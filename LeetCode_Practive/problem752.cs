using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem752
    {
        public void Main752(string[] args)
        {
            //https://leetcode.com/problems/open-the-lock/
            //help from
            //https://www.youtube.com/watch?v=Pzg3bCDY87w
            //https://leetcode.com/problems/open-the-lock/discuss/417274/C-Solution
            string[] deadends = { "0201", "0101", "0102", "1212", "2002" };
            string target = "0202";
            int ans = OpenLock(deadends, target);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        public int OpenLock(string[] deadends, string target)
        {
            //check if it is possible to find target
            if (deadends.Contains("0000") || deadends.Contains(target))
                return -1;
            //create hashset to store strings we have visited. start with deadends because we cant visit those
            HashSet<string> visited = new HashSet<string>(deadends);
            //use q to find target
            Queue q = new Queue();
            q.Enqueue("0000");
            visited.Add("0000");
            int level = 0;
            //while q has elements, loop for target
            while (q.Count > 0)
            {
                int count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    //pop off first item in q
                    var current = q.Dequeue();
                    if (current.Equals(target))
                        return level;
                    //check all children of current string, add to visited and add to q if not already there or deadend
                    foreach (var child in GetChildren(current.ToString()))
                    {
                        if (!(visited.Contains(child)))
                        {
                            q.Enqueue(child);
                            visited.Add(child);
                        }
                    }
                }
                level++;
            }
            return -1;
        }

        public List<string> GetChildren(string current)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < current.Length; i++)
            {
                char[] arr1 = current.ToCharArray(), arr2 = current.ToCharArray();
                arr1[i] = arr1[i] == '9' ? '0' : (char)((int)arr1[i] + 1);
                result.Add(new string(arr1));
                arr2[i] = arr2[i] == '0' ? '9' : (char)((int)arr2[i] - 1);
                result.Add(new string(arr2));
            }
            return result;
        }
    }
}
