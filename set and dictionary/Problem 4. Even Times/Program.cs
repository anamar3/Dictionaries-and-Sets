using System;
using System.Collections.Generic;

namespace Problem_4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfnumbers = int.Parse(Console.ReadLine());

            Dictionary<double, double> numbers = new Dictionary<double, double>();

            for (int i = 0; i < numberOfnumbers; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if(!numbers.ContainsKey(currNum))
                {
                    numbers.Add(currNum, 0);
                }
                numbers[currNum]++;
            }

            foreach (var item in numbers)
            {
                if(item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
