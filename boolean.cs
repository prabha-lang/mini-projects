//string message = "The quick brown fox jumps over the lazy dog.";
//bool result = message.Contains("dog");
//Console.WriteLine(result);

//if (message.Contains("fox"))
//{           
//    Console.WriteLine("What does the fox say?");
//}

string message = " The quick brown fox jumps over the lazy dog.";
bool result = message.Contains(("fox"));
Console.WriteLine(result);

if (message.Contains("Dog"))
{
    Console.WriteLine("What did the fox Say?");
}
if (message.Contains(""))
{
    Console.WriteLine("You haven't typed anything");
}
