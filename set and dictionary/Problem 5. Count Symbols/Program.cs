using System;
using System.Collections.Generic;

namespace Problem_5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> chars = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            foreach (char ch in input)
            {
                if(!chars.ContainsKey(ch))
                {
                    chars.Add(ch, 0);
                }
                chars[ch]++;
            }

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
