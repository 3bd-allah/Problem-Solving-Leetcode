namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            var res = TwoSum(nums, 9);
            foreach (int x in res)
            {
                Console.WriteLine(x);
            }
        }

        public static int[] TwoSum(int[] numbers, int target)
        {

            int[] pointers = { 0, 0 };
            for (int i = 0, j = numbers.Length - 1; i < j;)
            {
                int sum = numbers[i] + numbers[j];
                if (sum > target)
                {
                    j--;
                     continue;
                }
                else if (sum < target)
                {
                    i++;
                    continue;
                }
                else
                {
                    pointers[0] = i + 1;
                    pointers[1] = j + 1;
                    break;
                }
            }
            return pointers;
        }
    }
}
