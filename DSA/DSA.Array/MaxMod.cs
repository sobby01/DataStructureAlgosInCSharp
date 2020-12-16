using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{

    /*
     * Given an array A of size N, groot wants you to pick 2 indices i and j such that

        1 <= i, j <= N
        A[i] % A[j] is maximum among all possible pairs of (i, j).
        Help Groot in finding the maximum value of A[i] % A[j] for some i, j.

        A = [1, 2, 44, 3] o/p : 3 % 44 = 3
        1 <= N <= 100000
        0 <= A[i] <= 100000
     * */
    public class MaxMod
    {
        public int Calculate(List<int> arr)
        {
            int ans = 0;
            int n = arr.Count;
             
            // Sort the array[] by using inbuilt 
            // sort function 
            arr.Sort();

            for (int j = n - 2; j >= 0; --j)
            {

                // Break loop if answer is greater 
                // or equals to the arr[j] as any 
                // number modulo with arr[j] can  
                // only give maximum value up-to 
                // arr[j]-1 
                if (ans >= arr[j])
                    break;

                // If both elements are same then 
                // skip the next loop as it would 
                // be worthless to repeat the 
                // rest process for same value 
                if (arr[j] == arr[j + 1])
                    continue;

                for (int i = 2 * arr[j];
                          i <= arr[n - 1] + arr[j];
                                       i += arr[j])
                {

                    // Fetch the index which is  
                    // greater than or equals to 
                    // arr[i] by using binary search 

                    int ind = Array.BinarySearch(arr.ToArray(), i);

                    if (ind < 0)
                        ind = Math.Abs(ind + 1);

                    else
                    {
                        while (arr[ind] == i)
                        {
                            ind--;

                            if (ind == 0)
                            {
                                ind = -1;
                                break;
                            }
                        }
                        ind++;
                    }

                    // Update the answer 
                    ans = Math.Max(ans, arr[ind - 1]
                                           % arr[j]);
                }
            }

            return ans;
        }
    }
}
