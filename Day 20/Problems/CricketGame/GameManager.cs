using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    internal class GameManager
    {
        Random rand = new Random();
        private Player player;
        private Computer computer;

        public GameManager()
        {
            computer = new Computer();
        }

        public void Play()
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            player = new Player(name);

            while (true)
            {
                Console.WriteLine($"{player.Name} is batting.");
                Batting();
                Console.WriteLine($"{player.Name}'s Score: {player.Score}");
                Console.WriteLine($"Computer needs {player.Score} from 12 balls.");

                Console.WriteLine("Computer is batting.");
                Balling();
                Console.WriteLine($"Computer's Score: {computer.Score}");

                if (player.Score < computer.Score)
                {
                    Console.WriteLine("Computer wins the match!");
                }
                else
                {
                    Console.WriteLine($"{player.Name} wins the match!");
                }
            }
        }
        public void Batting()
        {
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("Enter values : (1, 2, 3, 4, 5, 6)");
                var playerChoice = int.Parse(Console.ReadLine());
                var computerChoice = rand.Next(1, 7);
                Console.WriteLine($"Computer choice : {computerChoice}");
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("OUT");
                    break ;
                }
                else
                {
                    player.AddScore(playerChoice);
                }
            }             
        }
        public void Balling()
        {
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("Enter values : (1, 2, 3, 4, 5, 6)");
                var playererChoice = int.Parse(Console.ReadLine());
                var computerChoice = rand.Next(1, 7);
                Console.WriteLine($"Computer choice : {computerChoice}");
                if (playererChoice == computerChoice)
                {
                    Console.WriteLine("OUT");
                    break;
                }
                else
                {
                    computer.AddScore(computerChoice);
                }
            }
        }
    }
}
