using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    class Program
    {
        public static void Reverse(int[] arr)
        {

            int startPointer = 0;
            int endPointer = arr.Length - 1;

            while (startPointer <= endPointer)
            {
                int temp = arr[endPointer];
                arr[endPointer] = arr[startPointer];
                arr[startPointer] = temp;
                startPointer++;
                endPointer--;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new[] {3, 4, 6, 7, 8, 9, 1};

            Reverse(arr);


            RemoveAllAdjascentDuplicates rDuplicates = new RemoveAllAdjascentDuplicates();
            rDuplicates.RemoveDuplicates("abbaca");

            FindCommonCharacter commonCharacter = new FindCommonCharacter();
            commonCharacter.CommonChars(new string[] {"acabcddd", "bcbdbcbd", "baddbadb", "cbdddcac", "aacbcccd", "ccccddda", "cababaab", "addcaccd"});

            DecryptStringFromAToInt atoint = new DecryptStringFromAToInt();
            atoint.FreqAlphabets("10#11#12");

            ToLowerString lowerString = new ToLowerString();
            string loweredString = lowerString.ConvertTOLower("Hello");

            loweredString = lowerString.ConvertTOLower("HELLO");

            Max69Number n69obj = new Max69Number();
            n69obj.Maximum69Number(9969);


            BalancedString bs = new BalancedString();
            bs.balancedString("WQWRQQQW");

            GroupAnagrams groupAna = new GroupAnagrams();
            groupAna.groupAnagrams(new string[] {"eat", "tea", "tan", "ate", "nat", "bat"});

            RomanToInt toInt = new RomanToInt();
            toInt.ToInt("MCMIV");
            
            StringToAtoi toAtoi = new StringToAtoi();
            int converter = toAtoi.MyAtoi("   -42");
            Console.Write(converter);

            PermutationPalindrome pp = new PermutationPalindrome();
            //pp.IsPalindromicPerm("carerac");
            Console.WriteLine(pp.IsPalindromicPerm("carerac"));
            Console.WriteLine(pp.IsPalindromicPerm("aaa"));
            pp.IsPalindromicPerm("aab");
            Console.WriteLine(pp.IsPalindromicPerm("aab"));
            Console.WriteLine(pp.IsPalindromicPerm("aaa"));
            Console.WriteLine(pp.IsPalindromicPerm("abba"));
            Console.WriteLine(pp.IsPalindromicPerm("ababa"));
            Console.WriteLine(pp.IsPalindromicPerm("ababba"));
            //aab
            //carerac
            //aa
            //abba
            Console.ReadKey();

            Anagram anagram = new Anagram();
            bool isAnagram = anagram.AreAnagram("anagram", "nagaram");
            Console.WriteLine(isAnagram);
            Console.ReadKey();
        }
    }
}
