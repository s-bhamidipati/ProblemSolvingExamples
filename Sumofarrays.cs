using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExamples
{
    class Sumofarrays
    {
        public static void Main()
        {
            //int[] arr = { 2, 3, 1, 4, 5, 6, 9, 10, 12, 23 };
            //int givensum = 18;

            //int[] newarr = { };

            //for (int i = 0; i <= arr.Length-1; i++)
            //{
            //    newarr = newarr.Append(arr[i]).ToArray();
            //    if (newarr.Sum() == givensum)
            //    {

            //        break;
            //    }
            //}

            ////differentways to show array
            //Array.ForEach(newarr, Console.WriteLine);
            //Console.WriteLine("[{0}]", string.Join(",", newarr));
            //newarr.ToList().ForEach(i=>Console.WriteLine(i.ToString()));

            //findThePairs(new int[] { 2, 3, 1, 4, 5, 6, 9, 10, 12, 23 }, 18);

            //findThePairs(new int[]{ 4, 6, 5, -10, 8, 5, 20 }, 10);

            //findThePairs(new int[] { 4, -5, 9, 11, 25, 13, 12, 8 }, 20);

            //findThePairs(new int[] { 12, 13, 40, 15, 8, 10, -15 }, 25);

            //findThePairs(new int[] { 12, 23, 125, 41, -75, 38, 27, 11 }, 50);


            List<int> lst = new List<int> { 2, 3, 1, 4, 5, 6, 9, 10, 12, 23 };
            int i_sum = 18;
            HashSet<string> match_sum = new HashSet<string>();
            //int[] match_arr = { };

            for (int i = 1; i < lst.Count; i++)
            {
                var combinations = GetCombinations(lst, i);
                foreach (var matches in combinations)
                {
                    int tmp = matches.Sum();
                    if (tmp == i_sum)
                    {
                        match_sum.Add(string.Join(", ", matches));
                        //for(int j=0; j<matches)
                      //  match_arr = match_arr.Append<int>(matches.FirstOrDefault()).ToArray();
                    }
                }
            }

            foreach (var match in match_sum.OrderBy(x => x))
            {
               // Console.WriteLine(match);
                Console.WriteLine("[{0}]", string.Join(",", match));
            }
            //foreach (var match in match_arr.OrderBy(x => x))
            //{
            //    Console.WriteLine(match);
            //}
        }

        static void findThePairs(int[] inputArray, int inputNumber)
        {
            //int givennumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Pairs of elements whose sum is " + inputNumber + " are : ");

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] + inputArray[j] == inputNumber)
                    {
                        Console.WriteLine(inputArray[i] + " + " + inputArray[j] + " = " + inputNumber);
                    }
                }
            }
        }


        static IEnumerable<IEnumerable<T>> GetCombinations<T>(IEnumerable<T> list, int length)
        {
            if (length == 0)
                return new[] { new T[0] };

            return list.SelectMany((e, i) =>
                GetCombinations(list.Skip(i + 1), length - 1)
                    .Select(c => new[] { e }.Concat(c)));
        }


    }
}
