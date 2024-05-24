using System.Net.Http.Headers;

namespace IsPalindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
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
