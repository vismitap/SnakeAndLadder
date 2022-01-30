using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int playerPosition = 0, count = 0;
        public void Play()
        {
            Console.WriteLine("\n---The game has started---\n");
            Random random = new Random();
            int diceOutcome = random.Next(1,7);
            
            while (playerPosition < WINNING_POSITION)
            {
                int option = random.Next(0,3);
                switch (option)
                {
                    case NO_PLAY:
                        break;

                    case LADDER:
                        playerPosition += diceOutcome;
                        break;

                    case SNAKE:
                        playerPosition -= diceOutcome;
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        break;
                }
                count++;
                Console.WriteLine("Player position is: " + playerPosition);
            }
            Console.WriteLine("\nNumber of times dice was rolled : " + count + "\n");

        }
    }
}
