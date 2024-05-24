namespace MergeSortedArrayLeetcodeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };


            var test1 = nums1.Take(3).ToArray();
            var test2 = nums2.Take(3).ToArray();
            //foreach(var n in test1)
            //    Console.WriteLine(n);
            //Console.WriteLine("============================");

            //foreach (var n in test2)
            //    Console.WriteLine(n);
            //Console.WriteLine("============================");
            //var merge = test1.Concat(test2).ToArray();

            //foreach (var n in merge)
            //    Console.WriteLine(n);
            //Console.WriteLine("============================");

            //Array.Sort(merge);

            //foreach (var n in merge)
            //    Console.WriteLine(n);
            //Console.WriteLine("============================");

            Merge(nums1, 3, nums2, 3);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            //var test1 = nums1.Take(m).ToArray();
            //var test2 = nums2.Take(n).ToArray();

            //nums1 = test1.Concat(nums2).ToArray();
            //Array.Sort(nums1);

            Array.Copy(nums2, 0, nums1, m, n);
            //Array.Sort(nums1);


            foreach (var x in nums1)
                Console.WriteLine(x);
        }
    }
}
