
double budget = double.Parse(Console.ReadLine());

int counter = 0;
double sumOfProducts = 0;
bool isSuccess = true;

string product = Console.ReadLine();

while (product != "Stop")
{
    double priceForProduct = double.Parse(Console.ReadLine());
    counter++;

    if (counter % 3 == 0)
    {
        priceForProduct = priceForProduct / 2;
    }

    if (budget >= priceForProduct)
    {
        budget -= priceForProduct;
        sumOfProducts += priceForProduct;
    }
    else
    {
        Console.WriteLine("You don't have enough money!");
        Console.WriteLine($"You need {priceForProduct - budget:F2} leva!");
        isSuccess = false;
        break;
    }


    product = Console.ReadLine();
}

if (product == "Stop")
{
    Console.WriteLine($"You bought {counter} products for {sumOfProducts:F2} leva.");
}

