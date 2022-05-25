using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOFLines = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < numberOFLines; i++)
            {
                string[] chemEl = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in chemEl)
                {
                    elements.Add(item);
                }
            }
            Console.WriteLine(string.Join(' ',elements.ToList().OrderBy(x => x)));
        }
    }
}
