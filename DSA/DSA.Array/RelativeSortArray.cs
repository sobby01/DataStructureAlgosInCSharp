using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class RelativeSortArray
    {
        public int[] relativeSortArray(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> elementsMapper= new Dictionary<int, int>();
            int[] outputArray = new int[arr1.Length];

            for (int indexer = 0; indexer < arr2.Length; indexer++)
            {
                if (elementsMapper.ContainsKey(arr2[indexer]))
                {
                    elementsMapper[arr2[indexer]] = elementsMapper[arr2[indexer]] + 1;
                }
                else
                {
                    elementsMapper.Add(arr2[indexer], 1);
                }
            }

            List<int> otherElements = new List<int>();

            for (int indexer = 0; indexer < arr1.Length; indexer++)
            {
                if (elementsMapper.ContainsKey(arr1[indexer]))
                {
                    elementsMapper[arr1[indexer]] = elementsMapper[arr1[indexer]] + 1;
                }
                else
                {
                    otherElements.Add(arr1[indexer]);
                }
            }

            int[] otherElementsArray = new int[otherElements.Count];
            System.Array.Copy(otherElements.ToArray(), otherElementsArray, otherElements.Count);
            System.Array.Sort(otherElementsArray);

            int counter = 0;
            int outArrayIndexer = 0;

            foreach (var mapper in elementsMapper)
            {
                counter = mapper.Value;
                while (counter > 1)
                {
                    outputArray[outArrayIndexer] = mapper.Key;
                    outArrayIndexer++;
                    counter--;
                }
            }

            for (int otherIndexer = 0; otherIndexer < otherElementsArray.Length; otherIndexer++)
            {
                outputArray[outArrayIndexer++] = otherElementsArray[otherIndexer];
            }

            return outputArray;
        }
    }
}
