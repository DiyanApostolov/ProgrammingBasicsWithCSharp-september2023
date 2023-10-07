
string destenation = Console.ReadLine();

while (destenation != "End")
{
    double budget = double.Parse(Console.ReadLine());

    double savedMoney = 0;

    while (savedMoney < budget)
    {
        double currentMoney = double.Parse(Console.ReadLine());
        savedMoney += currentMoney;
    }

    Console.WriteLine($"Going to {destenation}!");

    destenation = Console.ReadLine();

}
