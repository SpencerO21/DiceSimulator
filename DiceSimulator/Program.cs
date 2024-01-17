using DiceSimulator;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("How many times do you want to roll the dice?");
        int numRolls = int.Parse(System.Console.ReadLine());
        DiceRoll diceRoll = new DiceRoll();

        int[] results = diceRoll.rollTheDice(numRolls);
        // Print the simulation results
        PrintSimulationResults(results, numRolls);

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    static void PrintSimulationResults(int[] results, int numRolls)
    {
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

        // Print the total number of rolls
        System.Console.WriteLine($"Total number of rolls = {numRolls}.");

        // Print the histogram
        for (int i = 2; i <= 12; i++)
        {
            double percentage = (double)results[i - 2] * 100 / numRolls;
            int percentageInt = (int)percentage;

            System.Console.WriteLine($"{i}: {new string('*', percentageInt)}");
        }
    }
}