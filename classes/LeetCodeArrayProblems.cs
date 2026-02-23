namespace ConsoleApp.CodeClass
{
    public class Leetcode
    {
        //Leetcode 121. Best Time to Buy and Sell Stock
        public int MaxProfit(int[] prices)
        {
            int currBuy = prices[0];
            int maxProfit = 0;
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (currBuy < prices[i])
                {
                    profit = prices[i] - currBuy;
                    maxProfit = Math.Max(profit, maxProfit);
                }
                else
                {
                    currBuy = prices[i];
                }
            }

            return maxProfit;
        }

        //Leetcode 2149. Rearrange Array Elements by Sign
        //This for the case when there is for sure equal number of +ve's and -vs's
        public int[] RearrangeArray(int[] nums)
        {
            int pos = 0;
            int neg = 1;
            int n = nums.Length;
            int[] temp = new int[n];

            for (int i = 0 ; i < n; i++)
            {
                if (nums[i] < 0) //Checks if the element is pos or neg if its neg we have to put it in the correct place that is from the second index
                {
                    temp[neg] = nums[i];
                    neg+=2;
                } else
                {
                    temp[pos] = nums[i];
                    pos+=2;
                }
            }

            return temp;
        }
    }
}
