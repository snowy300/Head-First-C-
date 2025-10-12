using System;

class AbilityScoreCalculator
{
    public int RollResult = 14;
    public double DivideBy = 1.75;
    public int AddAmount = 2;
    public int Minimum = 3;
    public int Score;
    public void CalculateAbilityScore()
    {
        // Divide the roll result by the DivideBy field
        double divided = RollResult / DivideBy;
        // Add AddAmount to the result of that division
        //we used + instead of += , it caused error of 2 became 10
        int added = AddAmount + (int) divided;

        // If the result is too small, use Minimum
        if (added < Minimum)
        {
            Score = Minimum;
        }
        else
        {
            Score = added;
        }
    }
    static void Main(string[] args)
    {
        AbilityScoreCalculator calculator = new AbilityScoreCalculator();
        while (true)
        {
            calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
            calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
            calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
            calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
            calculator.CalculateAbilityScore();
            Console.WriteLine("Calculated ability score: " + calculator.Score);
            Console.WriteLine("Press Q to quit , any other key to continue");
            char keyChar = Console.ReadKey(true).KeyChar;
            if ((keyChar == 'Q') || (keyChar == 'q')) return;
        }

    }
    /// <summary>
    /// Reads user input as int and writes a prompt
    /// </summary>
    /// <param name="lastUsedValue">Default value</param>
    /// <param name="prompt">Promt to print to console</param>
    /// <returns>The int value, if read or default value if unable to parse</returns>
    static int ReadInt(int lastUsedValue , string prompt)
    {
        Console.Write(prompt + "[" + lastUsedValue + "]: ");
        string line = Console.ReadLine();
        if(int.TryParse(line , out int value))
        {
            Console.WriteLine("   using value " + value);
            return value;
        }
        else
        {
            Console.WriteLine(" using default value " + lastUsedValue);
            return lastUsedValue;

        }
    }
    /// <summary>
    /// Reads user input as int and writes a prompt
    /// </summary>
    /// <param name="lastUsedValue">Default value</param>
    /// <param name="prompt">Prompt to print to console</param>
    /// <returns>The int value, if read or default value if unable to parse</returns>
    static double ReadDouble(double lastUsedValue , string prompt)
    {
        Console.Write(prompt + "[" + lastUsedValue + "]: ");
        string line = Console.ReadLine();
        if (double.TryParse(line, out double value))
        {
            Console.WriteLine("   using value " + value);
            return value;
        }
        else
        {
            Console.WriteLine(" using default value " + lastUsedValue);
            return lastUsedValue;

        }
    }
}