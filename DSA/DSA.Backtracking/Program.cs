using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DSA.Backtracking
{
    public class Program
    {
        static void Main(string[] args)
        {
            LC_1641_CountSortedVowel csv = new LC_1641_CountSortedVowel();
            csv.CountVowelStrings(2);
            return;

            string key = "IBMhardwareis\r\n“All";
            key = key.Replace(@"“", @"\");

            Console.WriteLine(key);

            //key = key.Replace(@"\r\n", @"\\r\\n").Replace(@"\r", @"\\r").Replace(@"\n", @"\\n").Replace(@"\f", @"\\f").Replace("”", "\"");
            
            

            StringPermutations permutations = new StringPermutations();
            permutations.PrintPermutations(new char[] { 'A', 'B', 'C' });
            return;

            string str1 = "<wzip><SolutionData><TeamspaceId>TTRE-ERTQ-RRRR-WERT</TeamspaceId></SolutionData></wzip>";

            XDocument xdoc = XDocument.Parse(str1);
            XElement newTag = new XElement("Metadata",
                new XElement("Version", 20));
            xdoc.Root.Add(newTag);

            string importedSolution = xdoc.ToString(SaveOptions.None);

            int val = 3 % 5;
            Console.WriteLine(val);
            int val1 = 3 / 5;
            Console.WriteLine(val1);
            val1 = 5 % 3;
            Console.WriteLine(val1);
            val1 = 5/3;
            Console.WriteLine(val1);
            Console.ReadKey();

            SwapInPairs.ListNode l4 = new SwapInPairs.ListNode(4, null);
            SwapInPairs.ListNode l3 = new SwapInPairs.ListNode(3, l4);
            SwapInPairs.ListNode l2 = new SwapInPairs.ListNode(2, l3);
            SwapInPairs.ListNode l1 = new SwapInPairs.ListNode(1, l2);
            SwapInPairs swapIn = new SwapInPairs();

            var node = swapIn.SwapNodesIterative(l1);
            //var node = swapIn.SwapPairs(l1);

            //Reverse 
            String str = "HEILOS";
            Console.Write("All permutations with " +
                          "repetition of {0} are: \n", str);
            StringPermutationWithRepeatition rp = new StringPermutationWithRepeatition();
            rp.allLexicographic(str);
            Console.ReadKey();

            

            Console.ReadKey();

            NQueen.Solve();
            Console.ReadKey();
        }
    }
}
