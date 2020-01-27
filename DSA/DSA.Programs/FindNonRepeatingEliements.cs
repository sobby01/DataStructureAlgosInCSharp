using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Programs
{
    public class FindNonRepeatingElements
    {
        public static void firstNonRepeating(int[] arr, int n)
        {
            int origValue = 0;
            int count = 2;
            ArrayList keys = new ArrayList();
            Dictionary<int, int>elementsMap = new Dictionary<int, int>();
            for (int indexer = 0; indexer < n; indexer++)
            {
                if (!elementsMap.ContainsKey(arr[indexer]))
                {
                    elementsMap.Add(arr[indexer], 1);
                    keys.Add(arr[indexer]);
                }
                else
                {
                    //elementsMap.Remove(arr[indexer]);
                    origValue = elementsMap[arr[indexer]];
                    elementsMap[arr[indexer]] = ++origValue;
                }
            }

            foreach (int element in keys)
            {
                if (elementsMap[element] == 1 && count > 0)
                {
                    Console.Write(element + " ");
                    count--;
                }

                //if (element.Value == 1 && count > 0)
                //{
                //    Console.Write(element.Key + " ");
                //    count--;
                //}

            }
        }
    }
}
