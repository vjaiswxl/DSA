using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp.CodeClass
{
    public class TopKElement
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                numDict[num] = numDict.GetValueOrDefault(num) + 1;
            }

            PriorityQueue<int,int> minQueue = new PriorityQueue<int,int>();  

            foreach (var value in numDict) {
                minQueue.Enqueue(value.Key, value.Value);

                if (minQueue.Count > k) {
                    minQueue.Dequeue();
                }
            }

            return nums;
        }
    }
}
