using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class PatternPrint
    {
        public List<List<int>> solve(int A)
        {
            List<List<int>> returnedArray = new List<List<int>>();
            returnedArray.Add(new List<int>() { 1 });

            for (int i=1; i < A; i++)
            {
                int j = 0;
                int[] arr = new int[i+1];
                while(j <= i)
                {
                    arr[j] = j + 1;
                    j++;
                }
                returnedArray.Add(arr.ToList());
            }

            return returnedArray;
        }

        public List<List<int>> solve2(int A)
        {
            List<List<int>> returnedArray = new List<List<int>>();
            returnedArray.Add(new List<int>() { 1 });
            int j = 0;
            int[] arr = new int[2];
            for (int i = 1; i < A;)
            {            
                if (j <= i)
                {
                    arr[j] = j + 1;
                    j++;
                    continue;
                }

                if( j >= i)
                {
                    i++;
                    j = 0;
                    returnedArray.Add(arr.ToList());
                    arr = new int[i + 1];
                }                
            }

            return returnedArray;
        }

        public void printPattern(int n)
        {
            // Variable initialization 
            // Line count 
            int line_no = 1;

            // Loop to print desired pattern 
            int curr_star = 0;
            for (line_no = 1; line_no <= n;)
            {
                // If current star count is less than 
                // current line number 
                if (curr_star < line_no)
                {
                    Console.Write("* ");
                    curr_star++;
                    continue;
                }

                // Else time to print a new line 
                if (curr_star == line_no)
                {
                    Console.WriteLine();
                    line_no++;
                    curr_star = 0;
                }
            }
        }
    }
}
