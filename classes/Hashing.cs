namespace ConsoleApp.CodeClass
{
    public class Hashing
    {
        //Brute Force -- Has a high time and space complexity, will give an error if the arr is empty
        public void HighLow(int[] arr)
        {
            int size = arr.Max() + 1; // for an arr like [1,100001] it will traverse 100001 times just to store two elements count

            int[] hash = new int[size];

            //hashing/pre-compute

            for (int i = 0; i < arr.Length; i++)
            {
                hash[arr[i]] += 1;
            }

            int high = int.MinValue;
            int low = int.MaxValue;
            int lowIndex = 0;
            int highIndex = 0;

            for (int i = 0; i < hash.Length; i++)
            {
                if (hash[i] < low && hash[i] != 0)
                {
                    low = hash[i];
                    lowIndex = i;
                }


                if (hash[i] > high)
                {
                    high = hash[i];
                    highIndex = i;
                }
            }

            Console.WriteLine($"Highest: {highIndex} && Lowest: {lowIndex}");

        }

        public void HighLow_Opt(int[] arr, int n)
        {
            if (arr == null || arr.Length == 0) return;
            
            Dictionary<int, int> Hash = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (Hash.ContainsKey(num)) Hash[num]++;
                else Hash[num] = 1;
            }

            int highFreq = int.MinValue;
            int lowFreq = int.MaxValue;
            int highVal = 0;
            int lowVal = 0;

            // 2. Iterate only over the numbers that actually appeared
            foreach (var pair in Hash)
            {
                // Check for High
                if (pair.Value > highFreq)
                {
                    highFreq = pair.Value;
                    highVal = pair.Key;
                }

                // Check for Low
                if (pair.Value < lowFreq)
                {
                    lowFreq = pair.Value;
                    lowVal = pair.Key;
                }
            }

            Console.WriteLine($"Highest Freq: {highVal} ({highFreq} times)");
            Console.WriteLine($"Lowest Freq: {lowVal} ({lowFreq} times)");
        }
    }
}