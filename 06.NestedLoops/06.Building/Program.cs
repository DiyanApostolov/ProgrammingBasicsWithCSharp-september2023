
int floorsOfBuilding = int.Parse(Console.ReadLine());
int roomsForEveryFloor = int.Parse(Console.ReadLine());

for (int floor = floorsOfBuilding; floor >= 1; floor--)
{
	for (int room = 0; room < roomsForEveryFloor; room++)
	{
		if (floor == floorsOfBuilding)
		{
			Console.Write($"L{floor}{room} ");
		}
		else if (floor % 2 == 0)
		{
			Console.Write($"O{floor}{room} ");
		}
		else 
		{
            Console.Write($"A{floor}{room} ");
        }
	}

	Console.WriteLine();
}