using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExamples
{
    class Largestof3NumbesExample
    {

        public static void Main()
        {
            int num1, num2, num3;

            Console.WriteLine("Enter First Number:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number:");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"{num1} is the largest");
                }
                else
                {
                    Console.WriteLine($"{num3} is the largest");
                }
            }
            else if(num2 > num3)
            {
                Console.WriteLine($"{num2} is the largest");
            }
            else
            {
                Console.WriteLine($"{num3} is the largest");
            }
            Console.ReadLine();

        }
    }
}
