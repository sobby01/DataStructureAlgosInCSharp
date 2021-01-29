using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class ValidateSubsequence
    {
        public bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int cIndexer = -1;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < array.Count; i++)
            {
                map.Add(i, array[i]);
            }

            foreach (var intVal in sequence)
            {
                if (!map.ContainsValue(intVal))
                {
                    return false;
                }
                else if (map.ContainsValue(intVal))
                {
                    int value = map.FirstOrDefault(x => x.Value == intVal).Key;

                    if (value > cIndexer)
                        cIndexer = value;
                    else
                        return false;
                }
            }

            return true;
        }
    }
}
