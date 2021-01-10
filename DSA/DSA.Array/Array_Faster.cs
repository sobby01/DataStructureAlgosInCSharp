using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class Array_Faster
    {
        public void CheckLoop()
        {
            int n = 20;

            int j = 0;
            for (int i = n; i > -1; i /= 2)
            {
                Console.WriteLine(++j);
            }

            //j = 0;
            //for (int i = 1; i < n; i *= 2)
            //{
            //    Console.WriteLine(++j);

            //}
        }
    }
}
