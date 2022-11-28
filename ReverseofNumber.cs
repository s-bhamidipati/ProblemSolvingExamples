using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExamples
{
    internal class ReverseofNumber
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            int reminder, reverse = 0;
            while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;


            }
            Console.WriteLine(reverse);
            Console.ReadKey();
        }
    }
}
