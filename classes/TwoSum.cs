using System;
using System.Collections.Generic;

namespace ConsoleApp.CodeClass
{
    public class TwoSumProblem
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numDict.ContainsKey(complement))
                {
                  
                    return [numDict[complement], i];
                }

                if (!numDict.ContainsKey(nums[i]))
                {
                    numDict.Add(nums[i], i);
                }
            }
            return new int[0];
        }

        //Code for problem where asjed if a sum exists in the arr between two elements
        //Use the two pointer approach
        public string TwoSum_2P(int[] nums, int target)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int left = 0;
            int right = n-1;

            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == target)
                {
                    return "Yes";
                }else if (sum < target)
                {
                    left++;
                } else
                {
                    right ++;
                }
            }

            return "No";
        }
    }
    
}