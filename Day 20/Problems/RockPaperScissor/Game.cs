using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Game
    {
        Random rand = new Random();
        private Player player;
        private Player computer;

        public Game(Player player, Player computer)
        {
            this.player = player;
            this.computer = computer;
        }

        public void Run()
        {
            while (player.Score < 10 && computer.Score < 10)
            {
                Console.WriteLine("Enter 1. Rock, 2. Paper, 3. Scissors: ");
                int playerOption = int.Parse(Console.ReadLine());
                int randomOption = rand.Next(1, 4);
                Console.WriteLine($"Computer chose: {randomOption}");

                if (playerOption == randomOption)
                {
                    Console.WriteLine("It is a draw.");
                }
                else if ((playerOption == 1 && randomOption == 3) ||
                         (playerOption == 2 && randomOption == 1) ||
                         (playerOption == 3 && randomOption == 2))
                {
                    Console.WriteLine("You won this round!");
                    player.Score++;
                }
                else
                {
                    Console.WriteLine("Computer won this round.");
                    computer.Score++;
                }

                Console.WriteLine($"Scores - {player.Name}: {player.Score}, {computer.Name}: {computer.Score}");
            }

            AnnounceWinner();
        }

        private void AnnounceWinner()
        {
            if (player.Score >= 10)
            {
                Console.WriteLine($"Congratulations, {player.Name}! You reached 10 points and won the game!");
            }
            else
            {
                Console.WriteLine($"Computer reached 10 points. Better luck next time, {player.Name}!");
            }
        }
    }
}
       