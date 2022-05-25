using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            List<int> print = new List<int>();
            input = input.OrderByDescending(x=>x).ToArray();

            for (int i = 0; i < 3; i++)
            {
                if(i >input.Length-1)
                {
                    break;
                }
                print.Add(input[i]);
               
            }
            Console.WriteLine(string.Join(' ',print));
        }
    }
}
