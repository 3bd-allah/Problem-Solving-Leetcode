namespace TwoSumUsingHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            foreach (int i in x) 
            Console.WriteLine(i);

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            // ==================  using HashTable => big o(n) ============================
            IDictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int curr = nums[i];
                // curr + x  = target 
                int x = target - curr;
                if (map.ContainsKey(x))
                {
                    return new int[] { map[x], i };
                }
                else
                {
                    map.Add(curr, i);
                }
            }
            return null; 

        }
    }
}
