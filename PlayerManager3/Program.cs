using System;
using System.Collections.Generic;

namespace PlayerManager3
{
    class Program
    {
        // Properties/Instance variables
        private List<Player> players;

        // Constructor
        private Program()
        {
            players = new List<Player>() { new Player("Mike", 20),
                new Player("Catarina", 1000) };
        }

        static void Main(string[] args)
        {
            Program prgm = new Program();
            prgm.Start();
        }

        private void Start()
        {
            Console.Clear();

            // Variables
            string choice;

            // Menu cicle
            do
            {
                // Show options
                Console.WriteLine("Menu  (Select option number)");
                Console.Write("Option 1:   Insert player.\n");
                Console.Write("Option 2:   List all players.\n");
                Console.Write("Option 3:   List players with greater score.\n");
                Console.Write("Option 4:   Exit.\n");

                // Save anwser

                choice = Console.ReadLine();

                // Verify anwser
                switch (choice)
                {
                    case "1":
                        InsertPlayer();
                        players.Sort();
                        break;

                    case "2":
                        ListPlayers(players);
                        break;

                    case "3":
                        ListGreaterThan();
                        break;

                    case "4":
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                            break;
                }


            } while (choice != "4");
        }

        private void InsertPlayer()
        {
            // Variables
            string name;
            int score;
            Player p;

            // Ask for player info
            Console.Write("Insert player name:  ");
            name = Console.ReadLine();
            Console.Write("Insert player score:  ");
            score = Convert.ToInt32(Console.ReadLine());

            // Add player
            p = new Player(name, score);
            players.Add(p);
        }

        private static void ListPlayers(IEnumerable<Player> players)
        {
            foreach(Player p in players)
                Console.WriteLine(p);
            Console.WriteLine();
        }

        private void ListGreaterThan()
        {
            // Variables
            int minScore;
            IEnumerable<Player> goodPlayers;

            // Ask minimum score
            Console.Write("Insert minimum:  ");
            minScore = Convert.ToInt32(Console.ReadLine());

            // Get players with minScore
            goodPlayers = GetPlayersWithScoreGreaterThanMin(minScore);

            ListPlayers(goodPlayers);

            Console.WriteLine();
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThanMin(int minScore)
        {

            foreach (Player p in players)
                if (p.Score > minScore)
                    yield return p;

        }
            
    }
}
