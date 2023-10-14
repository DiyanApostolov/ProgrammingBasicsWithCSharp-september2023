
// Input
string country = Console.ReadLine();
string tool = Console.ReadLine();

// Calculations

double scoreOne = 0;
double scoreTwo = 0;

if (country == "Russia")
{
	switch (tool)
	{
		case "ribbon":
            scoreOne = 9.100;
            scoreTwo = 9.400;
			break;
        case "hoop":
            scoreOne = 9.300;
            scoreTwo = 9.800;
            break;
        case "rope":
            scoreOne = 9.600;
            scoreTwo = 9.000;
            break;
    }
}
else if (country == "Bulgaria")
{
    switch (tool)
    {
        case "ribbon":
            scoreOne = 9.600;
            scoreTwo = 9.400;
            break;
        case "hoop":
            scoreOne = 9.550;
            scoreTwo = 9.750;
            break;
        case "rope":
            scoreOne = 9.500;
            scoreTwo = 9.400;
            break;
    }
}
else if (country == "Italy")
{
    switch (tool)
    {
        case "ribbon":
            scoreOne = 9.200;
            scoreTwo = 9.500;
            break;
        case "hoop":
            scoreOne = 9.450;
            scoreTwo = 9.350;
            break;
        case "rope":
            scoreOne = 9.700;
            scoreTwo = 9.150;
            break;
    }
}

double finalScore = scoreOne + scoreTwo;
double neededScore = 20 - finalScore;
double percentNeededScore = neededScore / 20 * 100;

Console.WriteLine($"The team of {country} get {finalScore:F3} on {tool}.");
Console.WriteLine($"{percentNeededScore:F2}%");

