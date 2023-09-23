
string input = Console.ReadLine();
int sum = 0;

for (int i = 0; i < input.Length; i++)
{
    char currentChar = input[i];

    if (currentChar == 'a')
    {
        sum += 1;
    }
    else if (currentChar == 'e')
    {
        sum += 2;
    }
    else if (currentChar == 'i')
    {
        sum += 3;
    }
    else if (currentChar == 'o')
    {
        sum += 4;
    }
    else if (currentChar == 'u')
    {
        sum += 5;
    }
}

Console.WriteLine(sum);
