using System;
using System.Collections.Generic;
using System.Linq;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> numbers = new Dictionary<string, int>();
            string [] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
              string number = input[i];
                if(numbers.ContainsKey(input[i]))
                {
                    numbers[number]++;

                }
                else
                {
                    numbers.Add(number, 1);
                }
                     
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
