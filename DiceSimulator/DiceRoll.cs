using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSimulator
{
    internal class DiceRoll
    {
        public int[] rollTheDice(int numRolls)
        {
            Random random = new Random();
            int[] diceRolls = new int[11];
            
            // Loop for the number of times the user wants to roll
            for (int i = 0; i < numRolls; i++)
            {
                // For each roll, generate a random number for each dice, add the number together
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int total = dice1 + dice2;

                diceRolls[total - 2]++;
            }
            return diceRolls;
        }
    }
}
