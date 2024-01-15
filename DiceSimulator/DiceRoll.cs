using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSimulator
{
    internal class DiceRoll
    {
        public DiceRoll() { 
            
        }

        public int[] rollTheDice(int numRolls)
        {
            Random random = new Random();
            int[] diceRolls = new int[11];
            int dice1 = 0;
            int dice2 = 0;
            int total = 0;
            // Loop for the number of times the user wants to roll
            for (int i = 0; i < numRolls; i++)
            {
                // For each roll, generate a random number for each dice, add the number together
                dice1 = random.Next(1, 13);
                dice2 = random.Next(1, 13);
                total = dice1 + dice2;

                switch (total)
                {
                    case 2:
                        diceRolls[0]++;
                        break;
                    case 3:
                        diceRolls[1]++;
                        break;
                    case 4:
                        diceRolls[2]++; break;
                    case 5:
                        diceRolls[3]++; break;
                    case 6:
                        diceRolls[4]++; break;
                    case 7:
                        diceRolls[5]++; break;
                    case 8:
                        diceRolls[6]++; break;
                    case 9:
                        diceRolls[7]++; break;
                    case 10:
                        diceRolls[8]++; break;
                    case 11:
                        diceRolls[9]++;
                        break;
                    case 12:
                        diceRolls[10]++; break;
                }

            }
            return diceRolls;
        }
    }
}
