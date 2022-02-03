using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ready for next problem Sire!");
            Console.ReadKey();
        }
    }
    public class RandomizedSet
    {
        public HashSet<int> hashSet;
        public RandomizedSet()
        {
            hashSet = new HashSet<int>();
        }

        public bool Insert(int val)
        {
            if (hashSet.Contains(val))
                return false;
            else
                hashSet.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if (!(hashSet.Contains(val)))
                return false;
            else
                hashSet.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            Random rand = new Random();
            if(hashSet.Count == 1)
                return hashSet.ToList()[0];
            int randNum = rand.Next(0, hashSet.Count() - 1);
            return hashSet.ToList()[randNum];
        }
    }
}
