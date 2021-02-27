using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BitManipulation
{
    public class PowerOf2
    {
        public bool Check(int number)
        {
            return (number & (number - 1)) == 0;
        }
    }
}
