using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExamples
{
    internal class ReverseofString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            //char[] charArray = name.ToCharArray();
            //Array.Reverse(charArray);
            //Console.WriteLine(new string(charArray));

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            Console.WriteLine(reverse);

            int[] arr = { 2, 3, 1, 4, 5, 6, 9, 10, 12, 23 };
            List<int> A = new List<int>(arr);

            int K = 18;

            // Function call
            Combination(A, K);
        }


        static void unique_combination(int l, int sum, int K,
                                   List<int> local,
                                   List<int> A)
        {
            // If a unique combination is found
            if (sum == K)
            {
                Console.Write("{");
                for (int i = 0; i < local.Count; i++)
                {
                    if (i != 0)
                        Console.Write(" ");
                    Console.Write(local[i]);
                    if (i != local.Count - 1)
                        Console.Write(", ");
                }
                Console.WriteLine("}");
                return;
            }

            // For all other combinations
            for (int i = l; i < A.Count; i++)
            {
                // Check if the sum exceeds K
                if (sum + A[i] > K)
                    continue;

                // Check if it is repeated or not
                if (i > l && A[i] == A[i - 1])
                    continue;

                // Take the element into the combination
                local.Add(A[i]);

                // Recursive call
                unique_combination(i + 1, sum + A[i], K, local,
                                   A);

                // Remove element from the combination
                local.RemoveAt(local.Count - 1);
            }
        }

        static void Combination(List<int> A, int K)
        {
            // Sort the given elements
            A.Sort();

            // To store combination
            List<int> local = new List<int>();

            unique_combination(0, 0, K, local, A);
        }

    }
}
//https://www.geeksforgeeks.org/all-unique-combinations-whose-sum-equals-to-k/