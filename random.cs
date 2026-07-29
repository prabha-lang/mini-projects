Random dice = new();
int roll1 = dice.Next(50);
int roll2 = dice.Next();
int roll3 = dice.Next(50 , 150);

Console.WriteLine($"Roll  1: {roll1}");
Console.WriteLine($"Roll  2: {roll2}");
Console.WriteLine($"Roll  3: {roll3}");
