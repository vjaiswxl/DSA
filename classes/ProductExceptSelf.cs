using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp.CodeClass
{
    public class ProductExceptSelfProb
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            
            List<int> Products = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int product = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] != nums[j])
                    {
                        product = product * nums[j];
                    } 
                }
                Products.Add(product);
            }

            return Products.ToArray();
        }
    }
}