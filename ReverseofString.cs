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
        }
    }
}
