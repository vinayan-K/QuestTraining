using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    internal class GameManager
    {

        private Player player;
        private Minesweeper minesweeper;

        public void Play()
        {
            Console.WriteLine("Enter Player Name: ");
            string name = Console.ReadLine();
            player = new Player(name);
            minesweeper = new Minesweeper(player);

            while (true)
            {
                Console.WriteLine($"{player.Name}, choose a cell (row and column, e.g., 0 1): ");
                var input = Console.ReadLine().Split(' ');

                if (!int.TryParse(input[0], out int row) ||
                    !int.TryParse(input[1], out int col) ||
                    row < 0 || row >= 5 || col < 0 || col >= 5)
                {
                    Console.WriteLine("Invalid input. Please enter valid row and column (0-4).");
                    continue;
                }
                
                if (minesweeper.RevealCell(row, col))
                {
                    break; 
                }
            }

            Console.WriteLine("Your Score is : " + player.Score);
        }
    }
}        

