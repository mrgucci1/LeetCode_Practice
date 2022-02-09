using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem133
    {
        public void Main133()
        {
            //https://leetcode.com/problems/clone-graph/
            //help from
            //https://www.youtube.com/watch?v=mQeF6bN8hMk

        }
        static Node CloneGraph(Node node)
        {
            //use hashmap to track nodes we have already clones
            Dictionary<Node, Node> hashMap = new Dictionary<Node, Node>();
            //if our given node is null, return null
            if (node == null)
                return null;
            //call deapth first search with given node
            return dfs(node, hashMap);
        }
        static Node dfs(Node node, Dictionary<Node, Node> hashMap)
        {
            //if we have already copied this node, return the new node from hashmap
            if (hashMap.ContainsKey(node))
                return hashMap[node];
            //create a copy, add to our hashmap
            Node copy = new Node(node.val);
            hashMap.Add(node, copy);
            //for each of the neighbors, add it to our copy and call dfs 
            foreach (Node neighbor in node.neighbors)
                copy.neighbors.Add(dfs(neighbor, hashMap));
            return copy;
        }
    }
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
