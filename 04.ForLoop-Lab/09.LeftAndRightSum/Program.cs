
int n = int.Parse(Console.ReadLine());

int leftSum = 0;
int rigthSum = 0;

for (int i = 1; i <= n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    leftSum += currentNumber;
}

for (int i = 1; i <= n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    rigthSum += currentNumber;
}

if (leftSum == rigthSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    int diff = Math.Abs(leftSum - rigthSum);

    Console.WriteLine($"No, diff = {diff}");
}

