using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        const int WINNING_POSITION = 100;
        static void Main(string[] args)
        {

            Console.WriteLine("*********Welcome to Snake and Ladder problem!*********");
            Console.WriteLine("\n---The game has started---\n");

            SnakeAndLadder player1 = new SnakeAndLadder();
            SnakeAndLadder player2 = new SnakeAndLadder();
            
            int i = 0;
            bool flag = true;

            while (flag)
            {
                int player1Position = 0, player2Position = 0;

                if (i % 2 == 0)
                {

                    player1Position = player1.Play();
                }
                else
                {
                    player2Position = player2.Play();
                }

                if (player1Position == WINNING_POSITION)
                {
                    Console.WriteLine("Player1 won the game! \n");
                    flag = false;
                }
                if(player2Position == WINNING_POSITION)
                {
                    Console.WriteLine("Player2 won the game! \n");
                    flag = false;
                }
                i++;
            }
            
        }
    }
}
