using System;
using System.Collections.Generic;

namespace ConsoleApp.CodeClass
{
    public class LinearSearchProb
    {
        public int LinearSearch(List<int> nums, int target) {
        int result = -1;
        for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == target)
                {
                    result = i;
                    break;
                }
            }
        return result; 
        }
    }
}