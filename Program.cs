// Welcome to Dice Roll Sim
Console.Clear();

#nullable disable
Console.WriteLine("Dice Sim Menu");
Console.WriteLine("1:Roll Dice Once");
Console.WriteLine("2:Roll Dice 5 Times");
Console.WriteLine("3:Roll Dice 'n' times");
Console.WriteLine("4:Roll Dice until Snake Eyes");
Console.WriteLine("5:Exit");
// Main Loop
int die1 = 0;
int die2 = 0;
while (true)
{
    // Dice Sim Menu
    Console.Write("\nSelect an option (1-5): ");
    string roll = Console.ReadLine();

    // Process Input
    if (roll == "1") {
        Console.WriteLine("1 is working");
    } else if (roll != "1"){
        Console.WriteLine("1 is working but was not chosen");
        
    } else if (roll == "5") {
        break;
    }
}
