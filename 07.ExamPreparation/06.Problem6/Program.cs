
int countOfDays = int.Parse(Console.ReadLine());
int countOfHours = int.Parse(Console.ReadLine());

double finalPrice = 0;

for (int day = 1; day <= countOfDays; day++)
{
    double dayPrice = 0;

    for (int hour = 1; hour <= countOfHours; hour++)
	{
		if (day % 2 == 0 && hour % 2 == 1)
		{
			finalPrice += 2.50;
			dayPrice += 2.50;
		}
		else if (day % 2 == 1 && hour % 2 == 0)
		{
			finalPrice += 1.25;
			dayPrice += 1.25;
		}
		else
		{
			finalPrice += 1;
			dayPrice += 1;
		}
	}

	Console.WriteLine($"Day: {day} - {dayPrice:F2} leva ");
}

Console.WriteLine($"Total: {finalPrice:F2} leva");
    
