Random dice = new();

int roll1 = dice.Next(1 , 7);
int roll2 = dice.Next(1 , 7);
int roll3 = dice.Next(1 , 7);
int Total = roll1 + roll2 + roll3;

Console.WriteLine($" you rolled a {roll1}, a {roll2}, and a {roll3}, for total {Total} ");

if (Total > 14)
{
    Console.WriteLine("you hit  da jackpot");
}
if (Total < 15)
{                              
    
    Console.WriteLine("you lost bitch");
}