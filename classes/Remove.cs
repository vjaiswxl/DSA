using System;
using System.Collections.Generic;

namespace ConsoleApp.CodeClass
{ 
    public class RemoveDuplicates
    {
        public void Remove(int[] nums)
        {
            int i = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    nums[j] = nums[i];
                }
                i += 1;
            }
        }
    }
}
