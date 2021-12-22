using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Valhiem", "New World", "Outward", "Divinity", "Balders Gate"
            };

            IEnumerable<string> result = videoGames.OrderByDescending(game => game.Length);

            foreach (string game in result)
            {
                Console.WriteLine(game);
            }
        }
    }
}
