namespace ConsoleApp.CodeClass
{
    public class MoveZeroesProblem
    {
        //Brute Force Approach
        public void MoveZeroes(int[] nums)
        {
            List<int> temp = new List<int>();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                {
                    temp.Add(nums[i]);
                }
            }

            //filling the first n elements with non-zero 

            for (int i = 0; i < temp.Count(); i++)
            {
                nums[i] = temp[i];
            }

            //filling zeros
            int k = temp.Count();

            for (int i = k; i < n; i++)
            {
                nums[i] = 0;
            }

        }

        //Optimal Approach
        public void MoveZeroesOpt(int[] nums) {
        
        int j = -1;
        int n = nums.Length;

        for (int i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                j = i;
                break;
            }
        }

        //No non zero present in the array
        // if (j == -1) {
        //     return nums;
        // }

        //Shifting In Place elements
        for (int i = j+1 ; i < n; i++){
            if (nums[i] != 0) {
                (nums[i],nums[j]) = (nums[j],nums[i]);
                j++;
            } 
        }
   
    }
    }
}