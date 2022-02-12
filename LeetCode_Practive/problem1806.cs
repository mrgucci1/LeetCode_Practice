using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    internal class problem1806
    {
        public void Main1806()
        {
            //https://leetcode.com/problems/minimum-number-of-operations-to-reinitialize-a-permutation/
            Console.WriteLine(ReinitializePermutation(4));
            Console.ReadKey();
        }
        public int ReinitializePermutation(int n)
        {
            //our perm array which will be modified
            int[] perm = new int[n];
            //count number of operations
            int operation = 0;
            //construct originale perm
            for (int i = 0; i < n; i++)
                perm[i] = i;
            //while our helper function is returning false
            while (!checkEqual(perm, operation))
            {
                //create a new array to store modifications
                int[] arr = new int[n];
                //loop through and apply equations given in problem
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                        arr[i] = perm[i / 2];
                    else if (i % 2 == 1)
                        arr[i] = perm[n / 2 + (i - 1) / 2];
                }
                //increment operation
                operation++;
                //set perm equal to modified array
                perm = arr;
            }
            //return total count of operations
            return operation;


        }
        //helper function to check if our new perm equals what the original was
        public bool checkEqual(int[] perm, int op)
        {
            //check if this is our first operation (if operation == 0, its first op)
            //if it was our first, then it would return true since
            //our original perm would be equal to the modified perm
            //so we return false to ensure we enter while loop atleast once
            if (op == 0)
                return false;
            //forloop to check if we equal what original perm would be
            //since the original perm is just 0 -> n, we can compare our
            //modified perm to i. 
            for (int i = 0; i < perm.Length; i++)
                if (perm[i] != i)
                    return false;
            return true;
        }
    }
}
