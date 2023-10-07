
int n = int.Parse(Console.ReadLine());

int validCombinations = 0;

for (int x = 0; x <= n; x++)
{
	for (int y = 0; y <= n; y++)
	{
		for (int z = 0; z <= n; z++)
		{
			int result = x + y + z;

            if (result == n)
			{
				validCombinations++;
			}
		}
	}
}

Console.WriteLine(validCombinations);