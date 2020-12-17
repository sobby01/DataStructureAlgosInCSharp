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
