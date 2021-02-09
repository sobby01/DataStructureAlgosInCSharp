using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    public class Subsets_Cl
    {
        public IList<IList<int>> FindSubsets(int[] nums)
        {
            IList<IList<int>> bbc = new List<IList<int>>();
            List<int> output = new List<int>();
            List<int> input = nums.ToList();
            Solve(output, input, ref bbc);

            return bbc;
        }


        public void Solve(List<int> output, List<int> input, ref IList<IList<int>> abc)
        {
            if(input.Count == 0)
            {
                abc.Add(new List<int>(output));
                return;
            }

            List<int> output1 = new List<int>(output);
            List<int> output2 = new List<int>(output);

            output2.Add(input[0]);
            input.RemoveAt(0);

            Solve(output1, input, ref abc);
            Solve(output2, input, ref abc);
        }

    }
}
