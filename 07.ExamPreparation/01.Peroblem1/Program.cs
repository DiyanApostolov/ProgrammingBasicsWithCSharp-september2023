// Input

string nameOfMovie = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());
int countOfTickets = int.Parse(Console.ReadLine());
double priceForTicket = double.Parse(Console.ReadLine());
int percentForTheater = int.Parse(Console.ReadLine());

// Calculations

double incom = countOfTickets * priceForTicket * countOfDays;
double theaterRent = percentForTheater * incom / 100;
double finalIncom = incom - theaterRent;

// Output

Console.WriteLine($"The profit from the movie {nameOfMovie} is {finalIncom:F2} lv.");