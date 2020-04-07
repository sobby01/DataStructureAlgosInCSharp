using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class FindAnagramsMapping
    {
        public int[] AnagramMappings(int[] A, int[] B)
        {
            int cIndexer = 0;
            int[] mapper = new int [A.Length];

            for (int indexer = 0; indexer < A.Length; indexer++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[indexer] == B[j])
                    {
                        mapper[cIndexer] = j;
                        cIndexer++;
                        break;
                    }
                }
            }

            return mapper;

        }
    }
}
