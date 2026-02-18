namespace ConsoleApp.CodeClass
{
    public class MajorityElement
    {
        //This is the optimal solution and uses the Moore's Voting Algorithm
        public int MajorityElementOne(int[] nums)
        {
            int n = nums.Length;
            int count = 0;
            int element = 0;

            for (int i = 0; i < n; i++)
            {
                if (count == 0)
                {
                    element = nums[i];
                } else if (nums[i] == element)
                {
                    count ++;
                } else
                {
                    count --;
                }
            }

            return element;
        }
    }
}