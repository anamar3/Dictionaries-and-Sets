using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] twoSets = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int firstSet = twoSets[0];
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
                int secondSet = twoSets[1];

            for (int i = 0; i < firstSet; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < secondSet; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }
            HashSet<int> final = new HashSet<int>();
            new HashSet<int>(first.Concat(second));


            foreach (var item in first)
            {
                foreach (var number in second)
                {
                    if (item == number)
                    {
                        final.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(' ', final));
        }
    }
}
