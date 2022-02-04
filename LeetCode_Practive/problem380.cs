using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem380
    {
        public void Main380()
        {
            //https://leetcode.com/problems/insert-delete-getrandom-o1/
            //help from
            //https://leetcode.com/problems/insert-delete-getrandom-o1/discuss/321789/C-implementation
            //https://leetcode.com/problems/insert-delete-getrandom-o1/discuss/287378/C-Code
            RandomizedSet obj = new RandomizedSet();
            bool param_1 = obj.Insert(1);
            bool param_2 = obj.Insert(1);
            bool param_3 = obj.Remove(1);
            int param_4 = obj.GetRandom();
        }
    }
    public class RandomizedSet
    {

        public Dictionary<int, int> hashMap;
        public List<int> randList;
        Random rand;
        public RandomizedSet()
        {
            hashMap = new Dictionary<int, int>();
            randList = new List<int>();
            rand = new Random();
        }

        public bool Insert(int val)
        {
            if (hashMap.ContainsKey(val))
                return false;
            randList.Add(val);
            //insert into hashmap and set the value equal to the position it will have in our list
            hashMap.Add(val, randList.Count - 1);
            return true;
        }

        public bool Remove(int val)
        {
            if (!hashMap.ContainsKey(val))
                return false;
            //set temp variable to the index of this value in list
            int valIndex = hashMap[val];
            //set randlist index to end of list 
            //copy the last index number over the number we want to remove.
            randList[valIndex] = randList[randList.Count() - 1];
            //update hashmap with new index of what used to be the last number in our list
            hashMap[randList[valIndex]] = valIndex;
            //remove from both
            hashMap.Remove(val);
            randList.RemoveAt(randList.Count() - 1);
            return true;
        }

        public int GetRandom()
        {
            return randList[rand.Next(0, hashMap.Count())];
        }
    }
}
