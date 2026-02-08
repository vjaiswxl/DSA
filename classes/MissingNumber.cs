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
    }
}