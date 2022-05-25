using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> statsFollowing = new Dictionary<string, List<string>>();
            Dictionary<string, int> howManyPeopleHefollows = new Dictionary<string, int>();
            while((input = Console.ReadLine()) != "Statistics")
            {

                string[] splitted = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if(splitted[1] == "joined")
                {
                    if(!statsFollowing.ContainsKey(splitted[0]))
                    {
                        statsFollowing.Add(splitted[0], new List<string>());
                       
                    }
                    if (!howManyPeopleHefollows.ContainsKey(splitted[0]))
                    {
                        howManyPeopleHefollows.Add(splitted[0], 0);
                    }
                   
                }
                if(splitted[1] == "followed")
                {
                    string firstVlogger = splitted[0];
                    string secondVlogger = splitted[2];
                    if(statsFollowing.ContainsKey(firstVlogger) && statsFollowing.ContainsKey(secondVlogger) && firstVlogger != secondVlogger && !statsFollowing[secondVlogger].Contains(firstVlogger))
                    {

                        statsFollowing[secondVlogger].Add(firstVlogger);
                        howManyPeopleHefollows[firstVlogger]++;
                    }
                }



            }
            int count = 2;
            Console.WriteLine($"The V-Logger has a total of {statsFollowing.Count} vloggers in its logs.");
          
            string theMostVlogger = statsFollowing.OrderBy(x => x.Value.Count).Last().Key;
            Console.WriteLine($"1. {theMostVlogger} : {statsFollowing[theMostVlogger].Count} followers, {howManyPeopleHefollows[theMostVlogger]} following");
            foreach (var item in statsFollowing[theMostVlogger].OrderBy(x =>x))
            {
                Console.WriteLine($"*  {item}");
            }

            //foreach (var item in statsFollowing.OrderByDescending(x=>x.Value.Count))
            //{
               
            //    if (item.Key != theMostVlogger)
            //    {
            //        Console.WriteLine($"{count}. {item.Key} : {item.Value.Count} followers, {howManyPeopleHefollows[item.Key]} following");
            //        count++;
            //    }
            
            //        }

            Dictionary<string, Dictionary<int, int>> sleep = new Dictionary<string, Dictionary<int, int>>();
            foreach (var item in statsFollowing)
            {
                string vlogger = item.Key;
                if(item.Key!=theMostVlogger)
                {
                    if(!sleep.ContainsKey(vlogger))
                    {
                        sleep.Add(vlogger, new Dictionary<int, int>());
                    }
                    sleep[vlogger].Add(item.Value.Count, howManyPeopleHefollows[vlogger]);
                }
            }

            foreach (var d in sleep) 
            {
                int followers = 0;
                int following = 0;
                foreach (var item in d.Value.OrderByDescending(x=> x.Key).ThenBy(y =>y.Value))
                {
                    followers = item.Key;
                    following = item.Value;
                    Console.WriteLine($"{count}. {d.Key} : {followers} followers, {following} following");
                }
               
                count++;
            }
        }
    }
}
