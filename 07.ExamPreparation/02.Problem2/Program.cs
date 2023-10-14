// Input

using System.Reflection.PortableExecutable;

double budget = double.Parse(Console.ReadLine());
int countOfNigths = int.Parse(Console.ReadLine());
double priceForNigth = double.Parse(Console.ReadLine());
int percent = int.Parse(Console.ReadLine());

// Calculations

if (countOfNigths > 7)
{
    priceForNigth *= 0.95;
}

double priceForAllNigths = countOfNigths * priceForNigth;
double additionalSpend = percent * budget / 100;
double diff = budget - priceForAllNigths - additionalSpend;

// Output

if (diff >= 0)
{
    Console.WriteLine($"Ivanovi will be left with {diff:F2} leva after vacation.");
}
else
{
    Console.WriteLine($"{Math.Abs(diff):F2} leva needed.");
}