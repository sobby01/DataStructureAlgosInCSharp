using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class Beggers
    {
        public int solveBookLover(List<int> A)
        {
            int baseElement = A[0];
            List<int> map = new List<int>();
            List<int> B = new List<int>(A);
            int cc = B.Count;
            for (int i = 0; i < cc; i++)
            {
                
                int element = A[i];
                if (B.Contains(element))
                {
                    B.Remove(element);
                    if (B.Contains(element))
                    {
                        while (B.Contains(element))
                        {
                            B.Remove(element);
                        }
                        continue;
                    }
                    else
                    {
                        return element;
                    }
                   
                }
                else
                {
                    return element;
                }
            }

            return A[0];


        }


        public List<int> SolveBegger2(int A, List<List<int>> B)
        {
            int[] beggers = new int[A];

            foreach (var li in B)
            {
                int coins = li[li.Count - 1];
                int startIndex = li[0]-1;
                int endIndex = li[li.Count - 2]-1;


                beggers[startIndex] = beggers[startIndex] + coins;
                if ((endIndex + 1) < A)
                {
                    beggers[endIndex + 1] -= coins;
                }
            }
            for (int i = 1; i < A; i++)
            {
                beggers[i] = beggers[i] + beggers[i - 1];
            }

            return beggers.ToList();
        }
        public List<int> Solve(int A, List<List<int>> B)
        {
            List<int> beggers = new List<int>();
            
            foreach(var li in B)
            {
                int coins = li[li.Count - 1];
                int startIndex = li[0];
                int endIndex = li[li.Count - 2];

                for(int i = startIndex-1; i <=endIndex-1; i++)
                {
                    //beggers[i] = beggers[i] + coins;
                }
            }

            return beggers;
        }
    }
}
