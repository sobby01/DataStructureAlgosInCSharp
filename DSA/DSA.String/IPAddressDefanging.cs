using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class IPAddressDefanging
    {
        //Input: address = "1.1.1.1"
        //Output: "1[.]1[.]1[.]1"
        public string DefangIPaddr(string address)
        {
            address = address.Replace(".", "[.]");
            return address;
        }
    }
}
