using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem141
    {
        public void Main141()
        {
            //https://leetcode.com/problems/linked-list-cycle/
            //help from
            //https://www.youtube.com/watch?v=gBTe7lFR3vc
            //https://leetcode.com/problems/linked-list-cycle/discuss/856654/C-HashSet-solution

        }
        public bool HasCycle(ListNode head)
        {
            //hashset to store unquie values
            HashSet<ListNode> hashSet = new HashSet<ListNode>();
            while (head != null)
            {
                //if our hashset contains our node, we have a cycle
                if (hashSet.Contains(head))
                    return true;
                hashSet.Add(head);
                head = head.next;
            }
            return false;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
