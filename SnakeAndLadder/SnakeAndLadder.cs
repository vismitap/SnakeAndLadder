using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public void Play()
        {
            int startPosition = 0;
            Console.WriteLine("The game has started");
            Random random = new Random();
            int diceOutcome = random.Next(1,7);
            Console.WriteLine("The dice outcome is: "+diceOutcome);
        }
    }
}
