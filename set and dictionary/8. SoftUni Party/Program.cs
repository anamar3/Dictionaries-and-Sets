using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIPs = new HashSet<string>();
            HashSet<string> regulars = new HashSet<string>();
            string input = Console.ReadLine();


            while (input != "PARTY")
            {
                
            
               
            
                    if(char.IsDigit(input[0]))
                    {
                        VIPs.Add(input);
                    }
                    else
                    {
                        regulars.Add(input);
                    }
                
                input = Console.ReadLine();
            }

            while ((input = Console.ReadLine()) != "END")
            {
                if (VIPs.Contains(input))
                {
                    VIPs.Remove(input);
                }
                else if (regulars.Contains(input))
                {
                    regulars.Remove(input);
                }


            }

            int didntCome = regulars.Count + VIPs.Count;

            Console.WriteLine(didntCome);
            if (VIPs.Count > 0)
            {
                foreach (var item in VIPs)
                {
                    Console.WriteLine(item);
                }
            }
            if (regulars.Count >0)
            {
                foreach (var item in regulars)
                {
                    Console.WriteLine(item);
                }
            }
           
            



        }
    }
}
