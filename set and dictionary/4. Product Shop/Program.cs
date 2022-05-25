using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Revision")
            {
                string[] splitted = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = splitted[0];
                    string product = splitted[1];
                    double price = double.Parse(splitted[2]);
                if(!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product,price);

            }
            shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);
            foreach (var item in shops)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
