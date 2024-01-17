using Mission1Assignment;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        // Initialize RollDice class
        RollDice roll = new RollDice();

        // Initialize variable
        int numRolls = 0;

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        numRolls = int.Parse(System.Console.ReadLine());

        // Test numRolls
        //System.Console.WriteLine(numRolls);

        // Call RollDice class
        int[] finalArray = roll.rollIt(numRolls);

        // Display final message
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS \n" + 
                                 "Each '*' represents 1 % of the total number of rolls.\n" +
                                 "Total number of rolls = " + numRolls + "\n");

        // Display the final array
        for (int i = 0; i < finalArray.Length; i++)
        {
            // Calculate the percentage (rounded) of occurences
            int percentage = (int)Math.Round((finalArray[i]  * 100.0/ numRolls));

            // Print the total num :
            System.Console.Write((i + 2) + ": ");

            // Print out one * for each percent
            for (int j = 0; j < percentage; j++)
            {
                System.Console.Write("*");
            }

            // Print a new line
            System.Console.WriteLine();

        }

        // Display goodbye message
        System.Console.Write("\nThank you for using the dice throwing simulator. Goodbye!");


    }
}