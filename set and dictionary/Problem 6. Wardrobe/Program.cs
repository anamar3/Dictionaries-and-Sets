using System;
using System.Collections.Generic;

namespace Problem_6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> wardrode = new Dictionary<string, Dictionary<string, int>>();
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string colour = input[0];
                string theRest = input[1];
                string[] clothes = theRest.Split(',', StringSplitOptions.RemoveEmptyEntries);
                if (!wardrode.ContainsKey(colour))
                {
                    wardrode.Add(colour, new Dictionary<string, int>());
                }
                foreach (var item in clothes)
                {

                    if (!wardrode[colour].ContainsKey(item))
                    {
                        wardrode[colour].Add(item, 0);
                    }
                    wardrode[colour][item]++;
                }

            }
            string [] finalDecision = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string finalcolour = finalDecision[0];
            string finalClothing = finalDecision[1];
            bool isColourTrue = false;

            foreach (var item in wardrode)
            {
                if(item.Key == finalcolour)
                {
                    isColourTrue = true;
                }
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var thing in item.Value)
                {
                    if (thing.Key == finalClothing && isColourTrue == true)
                    {
                        Console.WriteLine($"* {thing.Key} - {thing.Value} (found!)");
                        isColourTrue = false;
                    }
                    else
                    {
                        Console.WriteLine($"* {thing.Key} - {thing.Value}");
                    }
                    
                }
            }
           

                     
            

        }
    }
}
