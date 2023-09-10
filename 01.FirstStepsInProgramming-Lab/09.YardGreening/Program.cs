double yardArea = double.Parse(Console.ReadLine());

double price = yardArea * 7.61;

double finalPrice = price - price * 0.18; // price * 0.82;
double discount = price * 0.18;

Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");
