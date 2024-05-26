namespace ArrayChanllengeBinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayChallenge(new string[] { "4", "3", "4", }));
            

        }

        public static string ArrayChallenge(string[] strArr)
        {
            bool IsMirror(int leftIndex, int rightIndex)
            {
                if (leftIndex >= strArr.Length && rightIndex >= strArr.Length)
                    return true;

                if ((leftIndex >= strArr.Length || strArr[leftIndex] == "#") && (rightIndex >= strArr.Length || strArr[rightIndex] == "#"))
                    return true;

                if (leftIndex >= strArr.Length || rightIndex >= strArr.Length || strArr[leftIndex] == "#" || strArr[rightIndex] == "#")
                    return false;

                if (strArr[leftIndex] != strArr[rightIndex])
                    return false;

                return IsMirror(2 * leftIndex + 1, 2 * rightIndex + 2) && IsMirror(2 * leftIndex + 2, 2 * rightIndex + 1);
            }

            if (strArr.Length == 0)
                return "true";

            return IsMirror(1, 2) ? "true" : "false";
        }


    }
}
