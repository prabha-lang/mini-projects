string[] fraudulantOrderIDs = new string[3];

fraudulantOrderIDs[0] = "A12BC";
fraudulantOrderIDs[1] = "B34DF";
fraudulantOrderIDs[2] = "C56GH";
//fraudulantOrderIDs[3] = "DG34J"; // This line will cause an error because the array only has 3 elements (indices 0, 1, and 2).

Console.WriteLine($"First : {fraudulantOrderIDs[0]}");
Console.WriteLine($"Second : {fraudulantOrderIDs[1]}");
Console.WriteLine($"Third : {fraudulantOrderIDs[2]}");

//need to see what will happen if i try to reassign th e value
fraudulantOrderIDs[0] = "FOO9";

Console.WriteLine($"Reaasigned First : {fraudulantOrderIDs[0]}");