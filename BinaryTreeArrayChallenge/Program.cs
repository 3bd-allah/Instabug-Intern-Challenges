using System.ComponentModel.DataAnnotations;

namespace BinaryTreeArrayChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] strings = {  };
            string[] strings1 = { "4", "3", "4"};
            string[] strings2 = { "10", "2", "2", "#", "1", "1", "#" };


            //Console.WriteLine(IsSymmetric(strings));
            //Console.WriteLine(IsSymmetric(strings1));
            //Console.WriteLine(IsSymmetric(strings2));

            //Console.WriteLine("====================================");

            //Console.WriteLine(ArrayChallenge(strings));
            //Console.WriteLine(ArrayChallenge(strings1));
            //Console.WriteLine(ArrayChallenge(strings2));

            //Console.WriteLine("====================================");

            Console.WriteLine(ArrayChallenge2(strings));
            Console.WriteLine(ArrayChallenge2(strings1));
            Console.WriteLine(ArrayChallenge2(strings2));





        }

        public static string ArrayChallenge(string[] strArr)
        {
            bool IsMirror(int leftIndex, int rightIndex)
            {
                // If both indices are out of bounds or both are '#', they are mirrors
                if (leftIndex >= strArr.Length && rightIndex >= strArr.Length)
                    return true;

                if ((leftIndex >= strArr.Length || strArr[leftIndex] == "#") && (rightIndex >= strArr.Length || strArr[rightIndex] == "#"))
                    return true;
                // If only one of them is out of bounds or '#', they are not mirrors
                if (leftIndex >= strArr.Length || rightIndex >= strArr.Length || strArr[leftIndex] == "#" || strArr[rightIndex] == "#")
                    return false;
                // If values are different, they are not mirrors
                if (strArr[leftIndex] != strArr[rightIndex])
                    return false;
                // Check the children: left's left with right's right and left's right with right's left
                return IsMirror(2 * leftIndex + 1, 2 * rightIndex + 2) && IsMirror(2 * leftIndex + 2, 2 * rightIndex + 1);
            }

            if (strArr.Length == 0)
                return "true";

            return IsMirror(1, 2) ? "true" : "false";
        }

        public static string ArrayChallenge2(string[] strArr)
        {
            // Function to check if two subtrees are mirror images of each other
            bool IsMirror(int leftIndex, int rightIndex)
            {
                // Base cases
                if (leftIndex >= strArr.Length && rightIndex >= strArr.Length) return true;
                if (leftIndex >= strArr.Length || rightIndex >= strArr.Length) return false;
                if (strArr[leftIndex] == "#" && strArr[rightIndex] == "#") return true;
                if (strArr[leftIndex] == "#" || strArr[rightIndex] == "#") return false;
                if (strArr[leftIndex] != strArr[rightIndex]) return false;

                // Check the children: left's left with right's right and left's right with right's left
                return IsMirror(2 * leftIndex + 1, 2 * rightIndex + 2) && IsMirror(2 * leftIndex + 2, 2 * rightIndex + 1);
            }

            // Start the check from the root node's children
            return IsMirror(1, 2) ? "true" : "false";
        }

        static bool IsSymmetric(string[] strArr)
        {
            bool IsMirror (int leftIndex, int rightIndex)
            {
                if(leftIndex >= strArr.Length && rightIndex >= strArr.Length) return true;
                if(leftIndex >= strArr.Length || rightIndex >= strArr.Length) return false;
                if (strArr[leftIndex] == "#" && strArr[rightIndex] == "#") return true;
                if (strArr[leftIndex] == "#" || strArr[rightIndex] == "#") return false;
                if (strArr[leftIndex] == strArr[rightIndex]) return true;
                if (strArr[leftIndex] != strArr[rightIndex]) return true;

                return IsMirror(2 * leftIndex + 1, 2 * rightIndex +2) && IsMirror(2 * leftIndex +2, 2 *rightIndex + 1);
            }

            return IsMirror(1,2); 
        }
    }
}
