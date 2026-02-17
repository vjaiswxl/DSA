using System.Globalization;

namespace ConsoleApp.CodeClass
{
    public class LongestSubArrayProb
    {
        public int LongestSubarray(int[] nums, int k)
        {
            //int[]  nums = [10, 5, 2, 7, 1, 9],  k=15

            int low = 0;
            int high = 1;
            int runningSum = nums[0];
            int maxCount = 0;
            int n = nums.Length;

            while (high < n)
            {
                while (low <= high && runningSum > k)
                {
                    runningSum -= nums[low];
                    low++;
                }

                if (runningSum == k)
                {
                    maxCount = Math.Max(maxCount, high - low + 1);
                }

                high ++;
                if (high < n)
                {
                    runningSum += nums[high];  
                }
            }

            return maxCount;
        }
    }
}