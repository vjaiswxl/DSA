using System;
using System.Collections.Generic;

namespace ConsoleApp.CodeClass
{
    public class SingleNumberProblem
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
            }

            return countMap.First(kvp => kvp.Value == 1).Key;
        }
    }
}