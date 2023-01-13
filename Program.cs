// Welcome to Dice Roll Sim
Console.Clear();

#nullable disable
Console.WriteLine("Dice Sim Menu");
Console.WriteLine("1:Roll Dice Once");
Console.WriteLine("2:Roll Dice 5 Times");
Console.WriteLine("3:Roll Dice 'n' times");
Console.WriteLine("4:Roll Dice until Snake Eyes");
Console.WriteLine("5:Exit");

// Create Random Objects
Random rnd = new Random();

// Main Loop

while (true)
{
    // Dice Sim Menu
    Console.Write("\nSelect an option (1-5): ");
    string roll = Console.ReadLine();

    // Process Input
    if (roll == "1")
    {
        int randNumA = rnd.Next(1, 7);
        int randNumB = rnd.Next(1, 7);
        Console.WriteLine($"{randNumA}, {randNumB} (Sum: {randNumA + randNumB})");
    }
    else if (roll == "2")
    {
        for (int n = 1; n <= 5; n++)
        {
            int randNumA = rnd.Next(1, 7);
            int randNumB = rnd.Next(1, 7);
            Console.WriteLine($"{randNumA}, {randNumB} (Sum: {randNumA + randNumB})");
        }
    }
    else if (roll == "3")
    {
        Console.WriteLine("Enter the number of times you want to roll");
        double ranD = Convert.ToDouble(Console.ReadLine());
        for (int n = 1; n <= ranD; n++)
        {
            int randNumA = rnd.Next(1, 7);
            int randNumB = rnd.Next(1, 7);
            Console.WriteLine($"{randNumA}, {randNumB} (Sum: {randNumA + randNumB})");
        }
    }
    else if (roll == "4")
    {
        int rollCnt = 0;
        while (true)
        {
            int randNumA = rnd.Next(1, 7);
            int randNumB = rnd.Next(1, 7);
            Console.WriteLine($"{randNumA}, {randNumB} (Sum: {randNumA + randNumB})");
            rollCnt++;
            if (randNumA == randNumB)
            {
                Console.WriteLine($"SNAKE EYES! It took {rollCnt} rolls to get snake eyes.");

                break;
            }
        }
    }
    else if (roll == "5")
    {
        Console.WriteLine("Thanks for using the Simulator");
        break;
    }
}
