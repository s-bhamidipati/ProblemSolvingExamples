using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExamples
{
    class SortingExample
    {
        public static void Main()
        {
            int[] num = { 1, 3, 10, 2, 15, 4 };
            int temp = 0;
           
            for(int i = 0; i <= num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.WriteLine("array sort in asscending order");
            foreach(var item in num)
            {
                Console.WriteLine(item);
            }
            Array.Sort(num);


            foreach (var val in num)
            {
                Console.WriteLine(val);
            }
            Array.Reverse(num);
            foreach (var val in num)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();

        }
    }
}
