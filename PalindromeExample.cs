using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExamples
{
    class PalindromeExample
    {

        public static void Main()
        {
            string input;
            string reverse = string.Empty;

            Console.WriteLine("please enter a string");
            input = Console.ReadLine();

            for(int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }

            if (reverse == input)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not a  palindrome");
            }

            //another method
            int n, r, sum = 0, temp;
            Console.WriteLine("enter the number=");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("palindrome number ");
            else
                Console.WriteLine("not palindrome");

            Console.ReadLine();
        }
    }
}
