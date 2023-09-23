
int n = int.Parse(Console.ReadLine());

for (int i = 0; i <= n; i+=2)
{
    double currentPower = Math.Pow(2, i);

    Console.WriteLine(currentPower);
}