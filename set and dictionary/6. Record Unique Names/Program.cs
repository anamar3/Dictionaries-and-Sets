using System;
using System.Collections.Generic;

namespace _6._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                            
            HashSet<string> people = new HashSet<string>();                   
            for (int i = 0; i <  n; i++)                                      
            {                                                                 
                string input = Console.ReadLine();                            
                people.Add(input);                                            
            }                                                                 
            foreach (var person in people)                                    
            {                                                                 
                                                                              
                Console.WriteLine(person);                                    
            }                                                                 
        }                                                                     
    }
}
