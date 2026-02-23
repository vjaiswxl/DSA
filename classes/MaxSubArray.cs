namespace ConsoleApp.CodeClass
{
    public class MaxSubArray
    {
        public int KadanesAlgo(int[] arr, int n)
        {
            int Max = int.MinValue;
            int sum = 0;

            int tempStart = -1;
            int start = -1;
            int end = -1;

            if (n == 1)
            {
                return arr[0];
            }

            for (int i = 0; i < n; i++)
            {
                if (sum == 0)
                {
                    tempStart = i; //To keep track of the sub array
                }
                sum += arr[i];
                if (sum > Max)
                {
                    Max = sum;
                    start = tempStart;
                    end = i;
                }

                if (sum < 0) //We are making the sum as 0, because if the sum drops below zero it will hamper or minimize our max sum
                {
                    sum = 0; //Dont carry any negatives
                }
            }


            return Max;

        }
    }
}