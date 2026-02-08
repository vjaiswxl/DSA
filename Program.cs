// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using ConsoleApp.CodeClass;


namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? choice = Console.ReadLine();

            //Test Cases
            int[] twoSumArr = [2, 4, 6, 1, 3, 5];
            string s = "anagram";
            string t = "nagaram";
            int[] twoSumNums = [2, 7, 11, 15];
            int target = 3;
            string[] strs = ["act", "pots", "tops", "cat", "stop", "hat", "cat"];
            int[] nums = [1, 2, 2, 3, 3, 3];
            int k = 2;
            IList<string> encodeStrs = [];
            int[] nums2 = [1, 2, 4, 6];
            int[] highLowArr = [10, 5, 10, 15, 10, 5];
            int[] numsConsecutive = [2, 20, 4, 10, 3, 4, 5];
            int[] unsortedArr = [13, 46, 24, 52, 20, 9];
            List<int> numsList = new List<int> { 0, 1, 2, 4, 5, 6 };

            switch (choice)
            {
                case "1":
                    var isDuplicateProb = new IsDuplicateProblem();
                    isDuplicateProb.IsDuplicate(twoSumArr);
                    break;
                case "2":
                    var IsAnagramProb = new isAnagramProblem();
                    IsAnagramProb.isAnagram(s, t);
                    break;

                case "3":
                    var twoSumProb = new TwoSumProblem();
                    twoSumProb.TwoSum(twoSumNums, target);
                    break;

                case "4":
                    var anagramGroupProb = new AnagramGroupProblem();
                    anagramGroupProb.GroupAnagrams(strs);
                    break;

                case "5":
                    var topKelement = new TopKElement();
                    topKelement.TopKFrequent(nums, k);
                    break;

                case "6":
                    var encodeDecode = new EncodeDecode();
                    string encodedString = encodeDecode.Encode(encodeStrs);
                    encodeDecode.Decode(encodedString);
                    break;

                case "7":
                    var productExceptSelf = new ProductExceptSelfProb();
                    productExceptSelf.ProductExceptSelf(nums2);
                    break;

                case "8":
                    var longestConsecutive = new LongestConsecutiveProb();
                    longestConsecutive.LongestConsecutive(numsConsecutive);
                    break;

                case "9":
                    var RemoveD = new RemoveDuplicates();
                    RemoveD.Remove(nums);
                    break;

                case "10":
                    var Linear = new LinearSearchProb();
                    Linear.LinearSearch(numsList, target);
                    break;

                case "11":
                    var Union = new UnionProblem();
                    Union.Union();
                    break;

                case "12":
                    var MissNum = new MissingNumProb();
                    MissNum.MissingNumber(numsList);
                    break;

                case "13":
                    var patterns = new Pattern();
                    patterns.Pattern_One(5);
                    break;

                case "14":
                    var pattern2 = new Pattern();
                    pattern2.Pattern_Two(5);
                    break;

                case "15":
                    var pattern3 = new Pattern();
                    pattern3.Pattern_Three(5);
                    break;

                case "16":
                    var pattern4 = new Pattern();
                    pattern4.Pattern_Four(5);
                    break;

                case "17":
                    var math = new Maths();
                    math.CountDigits_Brute(7789);
                    break;

                case "18":
                    math = new Maths();
                    math.ReverseNum(7789);
                    math.ReverseNum(121);
                    break;

                case "19":
                    math = new Maths();
                    //math.GCD(9, 12);
                    int ans = math.Euclidean(9, 12);
                    Console.WriteLine($"GCD is:{ans}");
                    break;

                case "20":
                    math = new Maths();
                    math.GetAllDivisors(36);
                    break;

                case "21":
                    math = new Maths();
                    math.CheckForPrime(36);
                    break;

                case "22":
                    var recursion = new Recursion();
                    //recursion.PrintNums(5,5);
                    //recursion.ReverseArray2P();
                    // recursion.IsPalindrome("ABA");
                    // recursion.IsPalindrome("VARUN");
                    recursion.Fibonacci(5);
                    break;


                case "23":
                    var hash = new Hashing();
                    hash.HighLow(highLowArr);
                    break;

                case "24":
                    var sort = new SortingAlgos();
                    // sort.SelectionSort(unsortedArr);
                    // sort.BubbleSort(unsortedArr);
                    sort.InsertionSort(unsortedArr);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }

    }
}

