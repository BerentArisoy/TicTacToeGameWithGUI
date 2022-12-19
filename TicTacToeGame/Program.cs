using BoardLogic;
using System;

namespace TicTacToe
{
    class Program
    {
        // Board is the data store for the game
        static Board game = new Board();
        static void Main(string[] args)
        {


            int userTurn = -1;
            int computerTurn = -1;
            
            Random rand = new Random();


            
            while (game.checkForWinner() == 0)
            {
                    while (userTurn == -1 || game.Grid[userTurn] != 0)
                    {
                        Console.WriteLine("Please enter a number from 0 to 8");
                        userTurn = int.Parse(Console.ReadLine());
                        Console.WriteLine("You Typed " + userTurn);
                    }
                    game.Grid[userTurn] = 1;

                if (game.isBoardFull())
                    break;
                // don't let the computer pick an invalid number
                    while (computerTurn == -1 || game.Grid[computerTurn] != 0)
                    {
                        computerTurn = rand.Next(9);
                        Console.WriteLine("Computer chooses " + computerTurn);
                    }
                    game.Grid[computerTurn] = 2;

                if (game.isBoardFull())
                    break;

                //show the board
                    printBoard();        
            }
            // while is done
                Console.WriteLine("The Game is Over ! Player " + game.checkForWinner() + " Won The Game!");
                Console.ReadLine();
        
        }

       


        private static void printBoard()
        {
            for (int i = 0; i < game.Grid.Length; i++)
            {
                // Console.WriteLine("Square " + i + " contains " + board[i]);
                // print x or o for each squre
                // 0 means unoccupied. 1 means player 1 (X) , 2 means player 2 (O)
                if(i % 3 == 0)
                {
                    Console.WriteLine();
                }

                if (game.Grid[i] == 0)
                {
                    Console.Write(".");
                }
                else if (game.Grid[i] == 1)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write("O");
                }
            }
            Console.WriteLine("-----------------");
        }
    }
}