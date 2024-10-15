using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExamples
{
    class factorial
    {
        public static void Main()
        {
            Console.WriteLine("please enter the factorial number");
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;
            for(int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.Write($"Factorial of {num}  is: {factorial}");
            Console.ReadKey();
        }
    }
}
