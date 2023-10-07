
int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int counter = 0;
bool isFound = false;

for (int i = start; i <= end; i++)
{
	for (int j = start; j <= end; j++)
	{
		counter++;

		int sum = i + j;

		if (sum == magicNumber)
		{
			Console.WriteLine($"Combination N:{counter} ({i} + {j} = {sum})");
			isFound = true;
			break;
		}
	}

	if (isFound)
	{
		break;
	}
}

if (!isFound)2
{
    Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
}




