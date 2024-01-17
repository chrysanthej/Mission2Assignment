using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission1Assignment
{
    internal class RollDice
    {
        public int[] rollIt(int numRolls)
        {
            // Create a Random object
            Random random = new Random();

            // Create array to keep track of number of times rolled each combo (2-12)
            int[] rollsArray = new int[11];

            // Go through both dice the number of rolls the user specifies
            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = random.Next(1, 7);
                int roll2 = random.Next(1, 7);

                int total = roll1 + roll2;

                rollsArray[total - 2] += 1;
            }

            // Return the array
            return rollsArray;
        }
    }
}
