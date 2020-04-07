using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    //Not Working
    public interface IMountainArray
    {
        int Get(int index);
        int Length();
    }

    public class FIndInMountainArray
    {
        public int findInMountainArray(int target, int[] mountainArr)
        {
            int start = 0;
            int end = mountainArr.Length;

            while (start < end)
            {
                int mid = start + (end - start) / 2;

                if (mountainArr[mid] < mountainArr[mid + 1])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            for (int indexer = 0; indexer <= start; indexer++)
            {
                if (mountainArr[indexer] == target)
                {
                    return indexer;
                }
            }

            return -1;
        }
    }
}
