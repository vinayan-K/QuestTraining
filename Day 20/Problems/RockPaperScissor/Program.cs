using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the player: ");
            string playerName = Console.ReadLine();
            var player = new Player(playerName);

            var computer = new Player("Computer");

            var game = new Game(player, computer);
            game.Run();
        }
    }
}
