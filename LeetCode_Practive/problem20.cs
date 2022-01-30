using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem20
    {
        public void Main20()
        {
            //https://leetcode.com/problems/valid-parentheses/
            //help from
            //https://www.youtube.com/watch?v=WTzjTskDFMg
            Console.WriteLine(IsValid("{[]}"));
            Console.ReadKey();
        }
        public bool IsValid(string s)
        {
            //quick exit, if s is odd number that means atleast 1 parenthesis does not close
            if (s.Length % 2 != 0)
                return false;
            //create stack to keep track of parenthesis
            Stack<char> stack = new Stack<char>();
            //hashmap to store types of parenthesis
            Dictionary<char, char> hashmap = new Dictionary<char, char>();
            hashmap.Add(')', '(');
            hashmap.Add('}', '{');
            hashmap.Add(']', '[');
            foreach (char c in s)
            {
                //if our hashmap contains the current closing parenthesis (since out closing parenthesis are the keys in hashmap)
                if (hashmap.ContainsKey(c))
                    //if our stack is not empty, we check the most recent value added to stack. if it equals the correct open parenthesis we remove from stack
                    if (stack.Count() > 0 && (stack.Peek() == hashmap[c]))
                        stack.Pop();
                    //else it is not valid
                    else
                        return false;
                else
                    //add to the stack opening parenthesis
                    stack.Push(c);
            }
            //if our stack is not empty, return false
            if (stack.Count > 0)
                return false;
            return true;

        }
    }
}
