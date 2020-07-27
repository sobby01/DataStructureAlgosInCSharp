using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace DSA.String
{
    public class MyClass
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public List<string> ErrorCode { get; set; }

    }

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
        static int Compare(KeyValuePair<string, int> a, KeyValuePair<string, int> b)
        {
            if (a.Key.CompareTo(b.Key) == 0)
            {
                return a.Value.CompareTo(b.Value);
            }
            return a.Key.CompareTo(b.Key);
        }

        static void Main(string[] args)
        {
            //Json Deserialize
            List<MyClass> myClass = new List<MyClass>();

            string json = "[{\"Name\":\"Medium Usage in Late Night Hours\",\"Status\":\"Failure\",\"ErrorCode\":[\"Policy_Not_Exist$##$Medium Usage in Late Night Hours\"]},{\"Name\":\"No Monthend Financial Postings\",\"Status\":\"Failure\",\"ErrorCode\":[\"Transaction_Not_Imported$##$No Monthend Financial Postings\"]},{\"Name\":\"High Usage\",\"Status\":\"Failure\",\"ErrorCode\":[\"Policy_Not_Exist$##$High Usage\"]}]"
;

            myClass = JsonConvert.DeserializeObject<List<MyClass>>(json);



            CountAndSay cands = new CountAndSay();
            var ss = cands.CountAndSay_Methody(6);
            Console.WriteLine(ss);
            Console.ReadKey();


            LongestPalindromicSubstring lps = new LongestPalindromicSubstring();
            Console.WriteLine(lps.LongestPSubstring());
            Console.ReadKey();
            CyclicPermutations cpermutations = new CyclicPermutations();
            cpermutations.FindCyclicPermutations();

            Tour cTour = new Tour();
            cTour.CalculateTour();

            TwitterTrend tt = new TwitterTrend();
            tt.ChkTwitterTrends();


            CommonPrime cp = new CommonPrime();
            cp.GetPrime();

            var number1 = Console.ReadLine();
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(number1);
            foreach (byte b in ASCIIValues)
            {
                Console.WriteLine(b);
            }

            //var number1 = Console.ReadLine();

            //var val = (int)number1;
            //Console.WriteLine(val);



            Dictionary<string,int> list1 = new Dictionary<string, int>();
            list1.Add("b5", 4);
            list1.Add("b6", 5);
            list1.Add("a7", 4);

            var lklist1 = list1.OrderBy(x => x.Value).ThenBy(x=>x.Key);
            foreach (KeyValuePair<string, int> pair in lklist1)
            {

            }

           

            Dictionary<string, int> list = new Dictionary<string, int>();
            list.Add("b5", 4);
            list.Add("b6", 5);
            list.Add("b5", 4);
            //list.OrderBy(x=>x.Value, new SeqComparer<KeyValuePair<string,int>>(new KeyValuePair<string,int>(x.Ke)));

            //list.Contains


            PermutationPalindrome pp1 = new PermutationPalindrome();
            pp1.CheckPalindrome();

            ZAlgorithm zAlgo = new ZAlgorithm();
            var solutions = zAlgo.PatternMaching("bcdfgabcd", "abcd");

            for (int i = 0; i < solutions.Count; i++)
            {
                Console.WriteLine(solutions[i]);
            }

            Console.ReadKey();

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
