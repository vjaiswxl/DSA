
namespace ConsoleApp.CodeClass
{
    public class UnionProblem
    {
        public List<int> Union()
        {
            List<int> nums1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> nums2 = new List<int> { 1, 2, 7 };

            //List<int> union = new List<int>();

            List<int> Combined = new List<int>();

            for (int i = 0; i < nums1.Count; i++)
            {
                Combined.Add(nums1[i]);
            }

            for (int i = 0; i < nums2.Count; i++)
            {
                Combined.Add(nums2[i]);
            }

            Combined.Sort();

            int k = 0;

            for (int j = 1; j < Combined.Count; j++)
            {
                if (Combined[k] != Combined[j])
                {
                    k++;
                    Combined[k] = Combined[j];
                }
            }

            Combined.RemoveRange(k + 1, Combined.Count - (k + 1));
            // union = nums1.Union(nums2).ToList();

            return Combined;
        }

        //using Set (Stores distinct/unique elements only)
        public void UnionSet()
        {
            List<int> nums1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> nums2 = new List<int> { 1, 2, 7 };

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums1.Count(); i++)
            {
                set.Add(nums1[i]);
            }

            for (int i = 0; i < nums2.Count(); i++)
            {
                set.Add(nums2[i]);
            }

            foreach (var val in set)
            {
                Console.WriteLine(val);
            }
        }
        
    }
}