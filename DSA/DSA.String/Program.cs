﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    class Program
    {
        static void Main(string[] args)
        {
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