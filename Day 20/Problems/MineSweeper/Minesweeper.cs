using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MineSweeper.CellState;

namespace MineSweeper
{
    internal class Minesweeper
    {
        private CellState[,] grid = new CellState[5, 5];
        public bool[,] _visited = new bool[5, 5];
        private Player player;

        public Minesweeper(Player player)
        {
            this.player = player;
            InitGrid();
            RenderGrid();
        }
        public void InitGrid()
        {
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var state = (CellState)random.Next(0, 3);
                    grid[i, j] = state;
                    _visited[i, j] = false;
                }
            }
        }
       
        public void MarkVisited(int row, int col)
        {
            _visited[row, col] = true; 
        }

        public void RenderGrid(bool reveal = false)
        {
            Console.WriteLine("Grid:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (_visited[i, j] || reveal)
                    {
                        switch (grid[i, j])
                        {
                            case CellState.Mines:
                                Console.ForegroundColor = ConsoleColor.Red; 
                                Console.Write("[M] ");
                                break;
                            case CellState.Point1:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("[1] ");
                                break;
                            case CellState.Point2:
                                Console.ForegroundColor = ConsoleColor.Green; 
                                Console.Write("[2] ");
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("(X) "); 
                    }
                }
                Console.WriteLine();
            }
        }
        public bool RevealCell(int row, int col)
        {          
            if (_visited[row, col])
            {
                Console.WriteLine("Cell already revealed. Try again.");
                return false;
            }
            MarkVisited(row, col);
            if (grid[row, col] == CellState.Mines)
            {
                Console.WriteLine("You hit a mine! Game over.");
                return true; 
            }
            else
            {
                int points = GetPointsForCell(grid[row, col]);
                player.Score += points;
                Console.WriteLine($"You revealed a cell with {points} points! Current Score: {player.Score}");
            }

            RenderGrid();
            return false; 
        }
        private int GetPointsForCell(CellState state)
        {
            switch (state)
            {
                case CellState.Point1:
                    return 1;
                case CellState.Point2:
                    return 2;
                case CellState.Mines:
                    return 0;
                default:
                    return 0;
            }
        }
    }

}

