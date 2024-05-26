using System.Collections.Generic;

namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(nums));
           
        }


        public static int RemoveDuplicates(int[] nums)
        {

            HashSet<int> set = new HashSet<int>();
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Add(nums[i])) 
                    continue;
            }
            //set.CopyTo(nums);

            foreach(var n in set)
                Console.WriteLine(n);
            Console.WriteLine("===================");

            return set.Count;
        }
    }
}
