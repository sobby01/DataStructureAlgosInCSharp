using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class Max69Number
    {
        public int Maximum69Number(int num)
        {
            //max length of 
            int a = (int)Math.Pow(10, num.ToString().Length);
            a = a - num;
            if (a != 1)
            {
                int b = (int)Math.Pow(10, a.ToString().Length - 1) * 3;
                return num + b;
            }
            else
            {
                return num;
            }
        }
    }
}
