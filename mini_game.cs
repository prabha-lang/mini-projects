
Random dice = new();

int roll1 = dice.Next(1 , 7);
int roll2 = dice.Next(1 , 7);
int roll3 = dice.Next(1 , 7);
int Total = roll1 + roll2 + roll3;

Console.WriteLine($" you rolled a = {roll1}, b = {roll2}, and c = {roll3}, for total = {Total} ");
if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
   if  ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("you rolled a triple plus 3 points for you");
        Total  += 3;
    }
    else
    {
        Console.WriteLine("you rolled a double plus 2 points for you");
        Total += 2;
    }
}
// ahh idhukula inoru else statement create panum
if (Total >= 16)
{
    Console.WriteLine("You win a watermelon!");
}
else if ( Total >= 10)
{                                
    Console.WriteLine("you win a mobile stand!");
} 
else if (Total == 7)
{
    Console.WriteLine("you win a carpet!");
}
else
{
    Console.WriteLine(" you  lost bitch!");
}
 
