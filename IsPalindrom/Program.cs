using System.Net.Http.Headers;

namespace IsPalindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));


            int[] array = { 4, 6, 23, 10, 1, 3 };

            foreach (var n in array)
                Console.WriteLine(n);
            Console.WriteLine("==================");
            Array.Sort(array);
            foreach (var n in array)
                Console.WriteLine(n);


        }


        public static bool IsPalindrome(string s)
        {
            char[] arr = s.ToCharArray();

            var charArray = arr.Where(c => Char.IsLetterOrDigit(c) || c == '-');

            string str = "", reverseStr ="";

            foreach(char c in charArray)
            {
                str += c;
            }
            Console.WriteLine(str); 
            foreach(char c in str.Reverse()) {
                reverseStr += c;
            }
            Console.WriteLine(reverseStr);

            Console.WriteLine();

            return str.ToLower() == reverseStr.ToLower(); 
        }
    }
}
