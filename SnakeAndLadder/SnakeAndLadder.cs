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
        int playerPosition = 0;
        public int Play()
        {
            Random random = new Random();
            
            while(playerPosition < WINNING_POSITION)
            {
                int diceOutcome = random.Next(1,7);
                int option = random.Next(0, 3);

                switch (option)
                {

                    case NO_PLAY:
                        break;

                    case LADDER:
                        playerPosition += diceOutcome;
                        diceOutcome = random.Next(1, 7);  
                        Play();
                        break;

                    case SNAKE:
                        playerPosition -= diceOutcome;
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        break;
                }
            }

            return playerPosition;

        }
    }
}
