using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExamples
{
    internal class NoOfInstance
    {
        static void Main(string[] args)
        {
            string str = "abcabcabc";
            char ch = 'a';
            int frq = 0;

            //using foreach
            foreach (char item in str)
            {
                if (item == ch)
                {
                    frq++;
                }
            }
            Console.WriteLine(frq);

            //using count 
            int count = str.Count(x => (x == ch));
            Console.WriteLine(count);

            //using where
            int count1 = str.Where(x => (x == ch)).Count();
            Console.WriteLine(count1);

        }
    }
}
