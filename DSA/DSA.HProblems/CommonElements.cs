using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashingProblems
{
    public class CommonElements
    {
        public List<int> Solve(List<int> A, List<int> B)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            List<int> list = new List<int>();
            foreach(int element in A)
            {
                if (map.ContainsKey(element))
                {
                    map[element] = ++map[element];
                }
                else
                {
                    map.Add(element, 1);
                }
            }

            foreach (int element in B)
            {
                if (map.ContainsKey(element))
                {
                    list.Add(element);

                    if(map[element] > 1)
                    {
                        map[element] = --map[element];
                    }
                    else
                    {
                        map.Remove(element);
                    }
                }
            }

            return list;

        }
    }
}
