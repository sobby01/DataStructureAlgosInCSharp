using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    //Leetcode : 39
    //Leetcode : 40
    public class Combination
    {

        //Combination sum only once
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<IList<int>> objList = new List<IList<int>>();

            System.Array.Sort(candidates);

            FindSum2(candidates, objList, new Dictionary<int, int>(), target, 0);

            return objList;
        }

        void FindSum2(int[] candidates, List<IList<int>> objList, 
            Dictionary<int, int> temp, int target, int start)
        {
            if (target == 0)
            {
                objList.Add(new List<int>(temp.Values));
            }

            for (int i = start; i < candidates.Length; i++)
            {
                // did not get this condition
                if(i > start && candidates[i] == candidates[i-1]) continue;
                if (!(candidates[i] > target))
                {
                    if (!(temp.ContainsKey(i) && temp.ContainsValue(candidates[i])))
                    {
                        temp.Add(i, candidates[i]);
                        int remain = target - candidates[i];
                        FindSum2(candidates, objList, temp, remain, i+1);
                        temp.Remove(i);
                    }
                    
                }
            }
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> objList = new List<IList<int>>();

            System.Array.Sort(candidates);

            FindSum(candidates, objList, new List<int>(), target,0);

            return objList;
        }

        void FindSum(int[] candidates, List<IList<int>> objList, List<int> temp, int target, int start)
        {
            if (target == 0)
            {
                objList.Add(new List<int>(temp));
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (!(candidates[i] > target))
                {
                    temp.Add(candidates[i]);
                    int remain = target - candidates[i];
                    FindSum(candidates, objList, temp, remain, i);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
    }
}
