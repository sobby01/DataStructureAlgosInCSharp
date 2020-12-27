using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    /*
        *Little Ponny is given an array, A, of N integers. In a particular operation, he can set any element of the array equal to -1.

        He wants your help for finding out the minimum number of operations required such that the maximum element of the resulting array is B. If it is not possible then return -1.

        Problem Constraints
        1 <= |A| <= 105
        1 <= A[i] <= 109

        Input Format
        The first argument of input contains an integer array, A.

        The second argument of input contains an integer, B.

        Output Format
        Return an integer representing the answer. 
        A = [2, 4, 3, 1, 5] B = 3
        output : 2 //We need to remove 4 and 5 to make 3 the biggest element. 
     */
    public class LittlePony_MaxValue
    {
        public int solve(List<int> A, int B)
        {
            int count = 0; bool valueFound = false;
            for(int i  = 0; i < A.Count; i++)
            {
                if(A[i] > B)
                {
                    count++;
                }
                else if(A[i] == B)
                {
                    valueFound = true;
                }
            }

            if (!valueFound)
                return -1;
            else
                return count;

        }
    }
}
