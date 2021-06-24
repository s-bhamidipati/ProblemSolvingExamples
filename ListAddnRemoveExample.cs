using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingExamples
{
    class ListAddnRemoveExample
    {
        public List<int> Data()
        {
            List<int> Input = new List<int>();
            Input.Add(2);
            Input.Add(3);
            List<int> Output = new List<int>();
            Output.Add(1);
            Output.Add(2);
            Output.Add(3);

            var result = Input.Intersect(Output).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            return Output;
        }

        public static void Main()
        {
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            ListAddnRemoveExample le = new ListAddnRemoveExample();
            le.Data();
        }
    }
}
