using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Games = new List<string>();
            Games.Add("No Man's Sky");
            Games.Add("Vagrant Story");
            Games.Add("Sonic 2");
            Games.Add("PRYZM: Legend of the Dark Unicorn: Chapter 1");
            Games.Add("Super Mario Bros.");
            Games.Add("Marble Madness");
            Games.Add("Ender Lilies");
            Games.Add("Metroid Fusion");
            Games.Add("Mad World");
            Games.Add("The Legend of Zelda: Ocarina of Time");
            Games.Add("Phoenix Wright - Ace Attorney");
            Games.Add("Journey");
            Games.Add("Baba Is You");
            Games.Add("Stardew Valley");

            //List<string> tempList = new List<string>();

            var tempList = Games.OrderBy(x => x.Length).ThenBy(x => x).ToList();

            foreach (string game in tempList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
