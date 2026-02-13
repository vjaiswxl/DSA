using System;
using System.Collections.Generic;

namespace ConsoleApp.CodeClass
{
    public class MissingNumProb
    {
        public int MissingNumber(List<int> nums)
        {

            //brute force
            //int missing = -1;
            // int n = nums.Count;

            // nums.Sort();

            // for (int i = 0; i < n; i++)
            // {
            //     if (nums[i] != i)
            //     {
            //         missing = i;
            //         break;
            //     }
            // }

            // Console.WriteLine(missing);

            // return missing;

            Dictionary<int, int> numsHash = new Dictionary<int, int>();

            for (int i = 1; i < nums.Count; i++)
            {
                for (int j = 0; j < nums.Count - 1; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        numsHash.Add(i, 1);
                    }
                    else
                    {
                        numsHash.Add(i, 0);
                    }

                }
            }

            return numsHash[0];
        }

        //Optimal Approach
        //The sum of the first n natural numbers is given by the formula (n * (n + 1)) / 2
        public int FindMising(int[] arr)
        {
            int sum = arr.Sum();

            int n = arr.Length +1; //use lenght +1 as we need to get the sum of all the first n numbers including the missing one

            long expectedSum = (long)(n * (n + 1)) / 2; //use long to avoid overflow

            int result = (int)(expectedSum - sum);

            Console.WriteLine(result);

            return result;
        }
    }
}