using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Backtracking
{
    public class LC_47Permutations2
    {
        Dictionary<int, int> li = new Dictionary<int, int>();
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            int[] count = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                count[i] = 1;

                if (li.ContainsKey(nums[i]))
                    li.Add(nums[i], ++li[nums[i]]);
                else
                {
                    li.Add(nums[i], 1);
                }
            }
            IList<IList<int>> finalList = new List<IList<int>>();
            Combinations(nums, count, 0, new int[nums.Length], ref finalList);

            return finalList;
        }

        private void Combinations(int[] nums, int[] count, int level, int[] result, ref IList<IList<int>> finalList)
        {
            if (level == nums.Length)
            {
                List<int> li = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    li.Add(result[i]);
                }
                bool contains = finalList.Any(x => (x.Select((y, i) => y == li[i]).All(y => y)));
                if(!contains)
                    finalList.Add(li);

                return;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    //if all my count array is 1 and my indexer is 1
                    //I should not use this.

                    if (level == 0)
                    {
                        if (!li.ContainsKey(nums[i]))
                        {
                            continue;
                        }
                        else
                        {
                            li.Remove(nums[i]);
                        }
                    }

                    if (count[i] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        result[level] = nums[i];
                        count[i]--;
                        Combinations(nums, count, level + 1, result, ref finalList);
                        count[i]++;
                    }

                }
            }
        }
    }
}
