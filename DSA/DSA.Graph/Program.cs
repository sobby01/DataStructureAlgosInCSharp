using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class Program
    {
        static void Main(string[] args)
        {
            GraphDemo graphD=new GraphDemo();
            graphD.BuildAndTraverse();
            Console.ReadKey();
        }
    }
}
