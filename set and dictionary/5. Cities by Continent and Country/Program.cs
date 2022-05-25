using System;
using System.Collections.Generic;

namespace _5._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var place = new Dictionary<string,Dictionary<string,List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if(!place.ContainsKey(continent))
                {
                    place.Add(continent, new Dictionary<string, List<string>>());
                }
                if(!place[continent].ContainsKey(country))
                {
                    string value = string.Empty;
                    place[continent].Add(country, new List<string>());
                }
                place[continent][country].Add(city);


            }

            foreach (var continenT in place)
            {

                Console.WriteLine($"{continenT.Key}: ");
                foreach (var country in continenT.Value)
                {
                    string cities = string.Join(", ", country.Value);
                    Console.WriteLine($"  {country.Key} -> {cities}");
                }

            }
        }
    }
}
