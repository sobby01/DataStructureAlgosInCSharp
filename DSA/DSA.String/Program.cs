using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace DSA.String
{
    class Program
    {
        static Regex newRegx1 = new Regex(@"^\d{1,15}($|(\.\d{1,3}$))");
        private static Regex newRegx = new Regex("^((([-][0 - 9]{0, 12 })|([0 - 9]{0,12}))([.][0 - 9]{0,6}))$");
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
            //Thread.CurrentThread.CurrentCulture
            string number = "123456789123";
            int decimalIndex = number.LastIndexOf(".");
            if (decimalIndex != 0 && decimalIndex <= 13 && number.Length <= 18 ||
                decimalIndex == 0 && number.Length <= 12)
            {
                Console.WriteLine("Match1");
            }

            number = "12345678912356577";
            decimalIndex = number.LastIndexOf(".");
            if (decimalIndex!= -1 && decimalIndex <= 13 && number.Length <= 18 ||
                decimalIndex == -1 && number.Length <= 12)
            {
                Console.WriteLine("Match1");
            }

            number = "123456789123.45678";
             decimalIndex = number.LastIndexOf(".");
            if (decimalIndex != -1 && decimalIndex <= 12 && number.Length <= 18 ||
                decimalIndex == -1 && number.Length <= 12)
            {
                 Console.WriteLine("Match1");
             }
            
             number = "1234567891223.45678";
             decimalIndex = number.LastIndexOf(".");
             if (decimalIndex != -1 && decimalIndex <= 12 && number.Length <= 18 ||
                 decimalIndex == -1 && number.Length <= 12)
            {
                Console.WriteLine("Match1");
            }
            number = "123456781223.456789";
             decimalIndex = number.LastIndexOf(".");
             if (decimalIndex != -1 && decimalIndex <= 12 && number.Length <= 18 ||
                 decimalIndex == -1 && number.Length <= 12)
            {
                Console.WriteLine("Match1");
            }
            number = "123456781223.4567898";
             decimalIndex = number.LastIndexOf(".");
             if (decimalIndex != -1 && decimalIndex <= 12 && number.Length <= 18 ||
                 decimalIndex == -1 && number.Length <= 12)
            {
                Console.WriteLine("Match1");
            }
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
