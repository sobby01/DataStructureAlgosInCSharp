using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class UniqueElements
    {
        public int Solve(List<int> A)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int count = 0;
            foreach (var element in A)
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

            foreach (var pair in map)
            {
                if (pair.Value > 1)
                {
                    count += pair.Value - 1;
                }
            }

            return count;
        }
    }
}
