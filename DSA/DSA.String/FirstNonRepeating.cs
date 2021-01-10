using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class FirstNonRepeating
    {
        public int singleNumber(List<int> A)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for(int i =0; i< A.Count; i++)
            {
                if (map.ContainsKey(A[i]))
                {
                    var value = map[A[i]];
                    map.Remove(A[i]);
                    map.Add(A[i], value + 1);
                }
                else
                {
                    map.Add(A[i], 1);
                }
            }

            foreach(var kv in map)
            {
                if (kv.Value != 3)
                    return kv.Key;
            }

            return -1;
        }

        public int GetSingle(List<int> A)
        {
            int ones = 0;
            int twos = 0;
            int not_threes;
            int x;
            for (int i = 0; i < A.Count; i++)
            {
                x = A[i];
                twos |= ones & x;           
                ones ^= x;                  
                not_threes = ~(ones & twos);
                ones &= not_threes;         
                twos &= not_threes;         
            }

            return ones;
        }
    }
}
