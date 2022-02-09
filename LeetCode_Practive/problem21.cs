using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem21
    {
        public void Main(string[] args)
        {
            //Console.WriteLine("Ready for my next problem Sire!");
            //Console.ReadKey();
            //https://leetcode.com/problems/merge-two-sorted-lists/
            //help from 
            //https://leetcode.com/problems/merge-two-sorted-lists/solution/

        }
        public ListNode21 MergeTwoLists(ListNode21 list1, ListNode21 list2)
        {
            ListNode21 list3 = new ListNode21();
            if (list1 == null)
                return list2;
            else if (list2 == null)
                return list1;
            else if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
    class ListNode21
    {
        public int val;
        public ListNode21 next;
        public ListNode21(int val = 0, ListNode21 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
}
