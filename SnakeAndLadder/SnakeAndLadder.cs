using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        int playerPosition = 0;
        public void Play()
        {
            Console.WriteLine("The game has started");
            Random random = new Random();
            int diceOutcome = random.Next(1,7);
            Console.WriteLine("The dice outcome is: "+diceOutcome);
            
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
                    break;

            }

            Console.WriteLine("Option is: "+ option +"\nPlayer position is: " + playerPosition);
        }
    }
}
