using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class GetAscii
    {
        public void PrintAscii(string s)
        {
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(s);
            foreach (byte b in ASCIIValues)
            {
                Console.WriteLine(b);
            }
        }
    }
}
