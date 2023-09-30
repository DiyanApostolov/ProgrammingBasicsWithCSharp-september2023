
string input = Console.ReadLine();

double bankBalance = 0;

while (input != "NoMoreMoney")
{
    double currentAmount = double.Parse(input);

    if (currentAmount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    bankBalance += currentAmount;
    Console.WriteLine($"Increase: {currentAmount:F2}");

    input = Console.ReadLine();
}

Console.WriteLine($"Total: {bankBalance:F2}");
