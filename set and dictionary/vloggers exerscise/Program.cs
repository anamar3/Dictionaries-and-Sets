using System;
using System.Collections.Generic;
using System.Linq;

namespace vloggers_exerscise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> vloggersWithTheirFollowers = new Dictionary<string, List<string>>();
            string input = string.Empty;
            Dictionary<string, int[]> following = new Dictionary<string, int[]>();

            while ((input = Console.ReadLine()) != "Statistics")
            {

                string[] splitted = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string user = splitted[0];
                if (splitted[1] == "joined")
                {
                    if (!vloggersWithTheirFollowers.ContainsKey(splitted[0]))
                    {
                        vloggersWithTheirFollowers.Add(splitted[0], new List<string>());
                        following.Add(splitted[0], new int[2]);
                    }
                }
                else if (splitted[1] == "followed")
                {
                    string userToFollow = splitted[2];
                    if (following.ContainsKey(user) && following.ContainsKey(userToFollow) && user != userToFollow && !vloggersWithTheirFollowers[userToFollow].Contains(user))
                    {
                        following[userToFollow][0]++;
                        following[user][1]++;
                        vloggersWithTheirFollowers[userToFollow].Add(user);
                    }


                }
            }
            int count = 2;
            Console.WriteLine($"The V-Logger has a total of {vloggersWithTheirFollowers.Count} vloggers in its logs.");

            string theMostVlogger = vloggersWithTheirFollowers.OrderBy(x => x.Value.Count).Last().Key;
            
            Console.WriteLine($"1. {theMostVlogger} : {vloggersWithTheirFollowers[theMostVlogger].Count} followers, {following[theMostVlogger][1]} following");
            if (vloggersWithTheirFollowers[theMostVlogger].Count > 0)
            {
                foreach (var item in vloggersWithTheirFollowers[theMostVlogger].OrderBy(x => x))
                {
                    Console.WriteLine($"*  {item}");
                }
            }

            foreach (var item in following.OrderByDescending(x => x.Value[0]).ThenBy(y => y.Value[1]))
            {
                string person = item.Key;
                int followers = item.Value[0];
                int followingS = item.Value[1];
                if (person != theMostVlogger)
                {
                    Console.WriteLine($"{count}. {person} : {followers} followers, {followingS} following");
                    count++;
                }
            }
        }
    }
}
