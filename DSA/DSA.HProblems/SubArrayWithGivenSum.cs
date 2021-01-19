using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashingProblems
{
    public class SubArrayWithGivenSum
    {
        public List<int> solve(List<int> A, int B)
        {
            List<int> returnList = new List<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, 1);
            bool found = false;
            int sum = 0;
            int i = 0;
            for (i = 0; i < A.Count; i++)
            {

                sum += A[i];

                if (map.ContainsKey(sum - B))
                {
                    found = true;
                }
                else
                {
                    map.Add(sum, i);
                }
            }

            if (found)
            {
                for (int j = map[sum - B] + 1; j <= i; j++)
                {
                    returnList.Add(A[j]);
                }
            }
            else
            {
                returnList.Add(-1);
            }

            return returnList;
        }
    }
}
