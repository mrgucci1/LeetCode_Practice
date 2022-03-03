using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    internal class problem938
    {
        int count = 0;
        public void Main938()
        {
            //https://leetcode.com/problems/range-sum-of-bst/
            //worked with Will Taylor
        }
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            helper(root, low, high);
            return count;
        }
        public void helper(TreeNode root, int low, int high)
        {
            if (root == null)
                return;
            if (root.val >= low && root.val <= high)
                count += root.val;
            helper(root.left, low, high);
            helper(root.right, low, high);

        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
