using System;
using System.Collections.Generic;

namespace ConsoleApp.CodeClass
{
    public class RotateArray
    {

        //This is for Rotating the first k elements to left
        public void LeftRotate(List<int> arr, int k)
        {
            List<int> temp = new List<int>();

            int n = arr.Count();

            //Inserting first k elements in temp
            for (int i = 0 ; i < k; i++)
            {
                temp.Add(arr[i]);
            }

            //Shifting other elements after k
            for (int i = k; i < n; i++)
            {
                arr[i-k] = arr[i];
            }
            
            //Putting Back the temp in the original array
            int j = 0;
            for (int i = n-k; i < n; i++)
            {
                arr[i] = temp[j];
                j++;
            }

            foreach(var el in arr)
            {
                Console.WriteLine(el);
            }
        }

        

        public void rotateArrayByOne(List<int> nums)
        {
            int n = nums.Count();

            if (n > 0)
            {
                (nums[0], nums[n - 1]) = (nums[n - 1], nums[0]);
            }

            for (int i = 0; i < n - 2; i++)
            {
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
            }

            foreach (var el in nums)
            {
                Console.WriteLine(el);
            }
        }
    }
}
