using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSA.ArrayDataStructure.SearchAlgos;

namespace DSA.ArrayDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            ToUpper tu = new ToUpper();
            tu.to_upper(new List<char>() { 'A', '{', 't', 'e', 'J' });

            MergeIntervals mi = new MergeIntervals();
            mi.Merge(new int[][] {
                new int[] { 1, 4 },
                new int[] {0, 2 },
                new int[] {3, 5 } });
            return;

            List<int> ll = new List<int>() { 1967513926, 1540383426, -1303455736, -521595368};
            var l2 = new List<int> { 0, 0, -1, 0 };

            MaximumPositivity mp = new MaximumPositivity();
            mp.maxset(ll);
            return;

            int a = '#' - 'a';
            Console.WriteLine(a);
            return;

            Beggers bg = new Beggers();
            var v1 = bg.solveBookLover(new List<int> { 1, 2, 3, 1, 2, 3 });

            v1 = bg.solveBookLover(new List<int> { 4,8,1,3,1 }); return;
            var colle = new List<List<int>>()
            {
                new List<int>(){ 1,2,10},
                new List<int>(){ 2,3,20},
                new List<int>(){ 2,5,25},
            };

            var arrRes = bg.SolveBegger2(5, colle);
            return;

           
            
            ValidateSubsequence vs = new ValidateSubsequence();
            vs.IsValidSubsequence(new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, -1, 10 });
            return;

            ElementRemovalCost ec = new ElementRemovalCost();
            ec.solve(new List<int>() { 3,0,9,7,8 });
            return;

            LC_345_ReverseVowels rv = new LC_345_ReverseVowels();
            rv.reverseVowels("aA");
            return;

            int modNUm = 11;

            Console.WriteLine(modNUm % 10);

            return;


            var listA = new List<int> { 8, 16, 80, 55, 32, 8, 38, 40, 65, 18, 15, 45, 50, 38, 54, 52, 23, 74, 81, 42, 28, 16, 66, 35, 91, 36, 44, 9, 85, 58, 59, 49, 75, 20, 87, 60, 17, 11, 39, 62, 20, 17, 46, 26, 81, 92 };
            KthSmallestNumber ksm = new KthSmallestNumber();
            int ele = ksm.kthsmallest(listA, 9);
            Console.WriteLine(ele);

            NobleElements ne = new NobleElements();
            ne.GetElement(new List<int> { 6, 7, 5 });
            return;

            List<int> A = new List<int>();
            int[] aa = A.ToArray();


            var abc = Math.Ceiling(Math.Log10(123));
            Console.WriteLine(abc);
            return;

            Add1ToNumber add1 = new Add1ToNumber();
            add1.plusOne(new List<int> { 0, 6, 0, 6, 4, 8, 8, 1 });
            return;

            Array_Faster af = new Array_Faster();
            af.CheckLoop();
            Console.ReadKey();
            return;

            PatternPrint pp = new PatternPrint();
            //pp.printPattern(5);

            pp.solve2(3);
            return;

            MaxEvenAndMinOdd memo = new MaxEvenAndMinOdd();
            memo.solve(new List<int>() { -98, 54, -52, 15, 23, -97, 12, -64, 52, 85 });
            return;

            int[] highArr = new int[] { 947, 871, 859, 471, 763, 766, 379, 746, 485, 966, 10, 350, 341, 22, 706, 702, 717, 967, 641, 712, 10, 954, 751, 250, 777, 214, 820, 276, 708, 509, 123, 73, 593, 790, 797, 678, 320, 865, 392, 428, 611, 813, 655, 195, 102, 902, 919, 171, 706, 841, 873, 98, 128, 728, 878, 701, 874, 158, 548, 214, 414, 600, 869, 936, 841, 221, 87, 255, 233, 627, 487, 53, 270, 162, 517, 576, 240, 681, 172, 148, 86, 778, 205, 741, 483, 11, 795, 188, 450 };
            int[] highArr1 = new int[] { 1,1,1,1,1,1,1,1,1,1,1,1 };

            ELementsWithTwoGreatest twoGreatest = new ELementsWithTwoGreatest();
            twoGreatest.solve(new int[] { 5,17,100,11 }.ToList());
            //twoGreatest.solve(new int[] { 1, 2, 3, 4, 5 }.ToList());
            return;

            StrictHigherAndLower hal = new StrictHigherAndLower();
            int vv = hal.Solve(highArr1.ToList());
            Console.WriteLine(vv);
            return;

            //A: [3, 4, 4, 6]
            //B: [20, 4, 18, 2]
            Solution123 ss = new Solution123();
            ss.solve(new List<int>() { 3, 4, 4, 6 }, new List<int>() { 20, 4, 18, 2});

            //ss.solve(new List<int>() { 23, 36, 58, 59 }, new List<int>() { 3, 207, 62, 654, 939, 680, 760, 835, 980 });
            return;

            LittlePonyAndMobilePhones lp = new LittlePonyAndMobilePhones();
            lp.solve(new List<int>() { 23, 36, 58, 59 }, new List<int>() { 3, 207, 62, 654, 939, 680, 760,835,980 });
            return;

            MaxDistance md = new MaxDistance();
            md.Calculate(new int[4] { 3, 5, 4, 2 });
            //md.Calculate(new int[9] { 2, 7, 13, 4, 1, 3, 10, 8, 11});
            return;

            MaxMod mm = new MaxMod();
            mm.Calculate(new List<int>() {11, 3, 4, 5, 9});
            return;

            Combination cmbSum = new Combination();

            var d = cmbSum.CombinationSum(new int[] { 2, 3, 6, 7 }, 7);

            int[] arr12 = new[] { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

            BinarySearch_Recursive recursive1 = new BinarySearch_Recursive();
            recursive1.BinarySearch(arr12, 23, 0, arr12.Length - 1);

            string[] list11 = new string[]{"Shogun", "Tapioca Express", "Burger King", "KFC"};
            string[] list12 = new string[] {"KFC", "Burger King", "Tapioca Express", "Shogun"};
            MinIndexSumOfTwoLists minIndexer122 = new MinIndexSumOfTwoLists();
            minIndexer122.FindRestaurant(list11, list12);

            RelativeSortArray sortArrayRel = new RelativeSortArray();
            sortArrayRel.relativeSortArray(new int[] {2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19},
                new int[] {2, 1, 4, 3, 9, 6});

            LengthOfLongestFIbonaaciSequence lenFib = new LengthOfLongestFIbonaaciSequence();
            lenFib.longestString(new int[] {1, 2, 3, 4, 5, 6, 7, 8});

            PeekInMountainArray array1 = new PeekInMountainArray();
            array1.FindPeakElement(new int[] {1, 2});

            FIndInMountainArray mountainArray = new FIndInMountainArray();
            mountainArray.findInMountainArray(2, new int[]
            {1,5,2
            });

            MergeSortedArray mergeArray1 =new MergeSortedArray();

            mergeArray1.Merge(new int[]{ 1, 2, 3, 0, 0, 0 },3, new int[]{2,5,6},  3);

            SquareOfSortedArray sortedArray = new SquareOfSortedArray();
            sortedArray.SortedSquares(new int[] {-4, -1, 8, 3, 10});

            CellWithOddValues objOddValues = new CellWithOddValues();
            objOddValues.OddCells(2, 3, new[] {new int[]{0, 1}, new int[]{1, 1}});

            UniqueIntegersSumZero sumZero = new UniqueIntegersSumZero();
            sumZero.SumZero(4);

            ReverseInteger rev = new ReverseInteger();
            rev.Reverse(-123);

            ArmstrongNumber aNumber = new ArmstrongNumber();
            aNumber.IsArmstrong(153);

            IntegerReplacement replacement = new IntegerReplacement();
            replacement.integerReplacement(2147483647);

            replacement.Replacement(11);


            MinTImeVistingAllPoints objPOints = new MinTImeVistingAllPoints();
            objPOints.MinTimeToVisitAllPoints(new int[][]
            {
                new []{
                    1, 1
                },
                new []{
                    3, 4
                },
                new []{
                    -1, 0
                }
            });


            MissingNumberinAP numberInAP= new MissingNumberinAP();
            numberInAP.MissingNumber(new int[] {5, 7, 11, 13});

            DominantNumber dn = new DominantNumber();
            dn.DominantIndex(new int[] {0, 0, 3, 2});
            dn.DominantIndex(new int[] { 3, 6, 1, 0 });
            dn.DominantIndex(new int[] { 1, 2, 3, 4 });

            int[] arr = new[] {2, 5, 8, 12, 16, 23, 38, 56, 72, 91};
            BinarySearch_Iterative iterative = new BinarySearch_Iterative();
            iterative.BinarySearch(arr, 23, 0, arr.Length-1);

            BinarySearch_Recursive recursive = new BinarySearch_Recursive();
            recursive.BinarySearch(arr, 23, 0, arr.Length-1);

            MaxSubArray subArray = new MaxSubArray();
            subArray.maxSubArray(new int[]{1,2});
            return;
            RainTrapWater trapWater = new RainTrapWater();
            trapWater.TrapWater(new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1});
            return;
            Combination comb = new Combination();
            comb.CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);

            int[] num1= new int[]
            {
                1,3,8,9,15
            };

            int[] num2 = new int[]
            {
                7,11,18,19,21,25
            };


            int[] num11 = new int[]
            {
                2
            };

            int[] num21 = new int[]
            {
                
            };

            Median_TwoSortedArray mergeArray = new Median_TwoSortedArray();
            var output = mergeArray.FindMedianSortedArraysOfTwoDifferentLength(num11, num21);

            Console.ReadKey();
            int[] list = new[] { -3,4,3,90};


            TwoSumChallenge sumChallenge = new TwoSumChallenge();
            sumChallenge.TwoSum(list, 0);

            list = new[] {42,39};
            Decompress_RunLength_EncodedList decompressedlist = new Decompress_RunLength_EncodedList();
            decompressedlist.DecompressRLElist(list);
        }
    }
}
