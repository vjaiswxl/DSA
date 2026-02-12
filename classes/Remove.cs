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

        public int RemoveDuplicate(int[] nums)
        {
            int n = nums.Length;
            int low = 0;
            int high = 1;
            while (high < n)
            {
                if (nums[low] == nums[high])
                {
                    high++;
                }
                else
                {
                    nums[low + 1] = nums[high];
                    low++;
                    high++;
                }
            }

            return low + 1;
        }
    }
}
