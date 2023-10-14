
int countOfMovies = int.Parse(Console.ReadLine());

string nameOfMaxMovieRating = "";
double maxMovieRating = 0;

string nameOfMinMovieRating = "";
double minMovieRating = double.MaxValue;

double allRatings = 0;

for (int i = 0; i < countOfMovies; i++)
{
    string nameOfMovie = Console.ReadLine();
    double currentRating = double.Parse(Console.ReadLine());
    allRatings += currentRating;

    if (maxMovieRating < currentRating)
    {
        maxMovieRating = currentRating;
        nameOfMaxMovieRating = nameOfMovie;
    }

    if (minMovieRating > currentRating)
    {
        minMovieRating = currentRating;
        nameOfMinMovieRating = nameOfMovie;
    }
}

Console.WriteLine($"{nameOfMaxMovieRating} is with highest rating: {maxMovieRating:F1}");
Console.WriteLine($"{nameOfMinMovieRating} is with lowest rating: {minMovieRating:F1}");

double averageRating = allRatings / countOfMovies;

Console.WriteLine($"Average rating: {averageRating:F1}");

