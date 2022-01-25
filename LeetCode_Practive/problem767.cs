using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    class problem767
    {
        public void Main(string[] args)
        {
            //https://leetcode.com/problems/reorganize-string/
            //help from
            //https://leetcode.com/problems/reorganize-string/discuss/414030/C-Solution
            //https://www.youtube.com/watch?v=2g_b1aYTHeg
            Console.WriteLine(ReorganizeString("aab"));
            Console.ReadKey();

        }
        public string ReorganizeString(string s)
        {
            //hashmap in c# to count frequency of characters
            Dictionary<char, int> charFreq = new Dictionary<char, int>();
            foreach (char ch in s)
            {
                if (!charFreq.ContainsKey(ch))
                {
                    charFreq[ch] = 0;
                }
                charFreq[ch]++;
            }
            //create *heap* to store characters and freq
            List<int[]> heap = new List<int[]>();
            //add to heap
            foreach (var occurance in charFreq)
            {
                heap.Add(new int[] { Convert.ToInt32(occurance.Key), occurance.Value });
            }
            //sort by most frequent
            heap.Sort((x, y) => -x[1].CompareTo(y[1]));
            //check if there is enough spots to handle the most frequent character
            if (heap[0][1] > (s.Length + 1) / 2)
                return "";
            char[] result = new char[s.Length];
            int index = 0;
            //loop through heap
            for (int i = 0; i < heap.Count(); i++)
            {
                //while frequncy of char  > 0
                while (heap[i][1] > 0)
                {
                    //reset index when we reach end of line
                    if (index >= result.Length)
                        index = 1;

                    result[index] = Convert.ToChar(heap[i][0]);
                    //cooldown, so we dont put most recent character twice
                    index += 2;
                    heap[i][1]--;
                }
            }
            return new string(result);

        }
    }
}
