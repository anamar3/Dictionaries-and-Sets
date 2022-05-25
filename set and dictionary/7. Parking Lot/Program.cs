using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            HashSet<string> cars = new HashSet<string>();


            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitted = input.Split(", ");
                string inORout = splitted[0];
                if (inORout == "IN")
                {
                    cars.Add(splitted[1]);
                }
                else if (inORout == "OUT")
                {
                    cars.Remove(splitted[1]);
                }


            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");

            }
            else
            {
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }

            }
            
        }
    }
}
