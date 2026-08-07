//initializse variablees graded students
int currentAssignment = 5;

int sophia1 = 100;
int sophia2 = 85;
int sophia3 = 98;
int sophia4 = 100;
int sophia5 = 97;

int andrew1 = 74;
int andrew2 = 98;
int andrew3 = 100;
int andrew4 = 94;
int andrew5 = 99;

int sha1 = 79;
int sha2 = 86;
int sha3 = 99;
int sha4 = 100;
int sha5 = 96;
 
int prabha1 = 100;
int prabha2 = 89;
int prabha3 = 94;
int prabha4 = 98;
int prabha5 = 93;

//initialize sum and average variables
int sophiaSum = 0;
int andrewSum = 0;
int shaSum = 0;
int prabhaSum = 0;

Decimal sophiaAverage;
Decimal andrewAverage;
Decimal shaAverage;
Decimal prabhaAverage;

//here comes da plane
sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
shaSum = sha1 + sha2 + sha3 + sha4 + sha5;
prabhaSum = prabha1 + prabha2 + prabha3 + prabha4 + prabha5;

//to calculate da average
sophiaAverage = (Decimal)sophiaSum/currentAssignment;
andrewAverage = (Decimal)andrewSum/currentAssignment;
shaAverage = (Decimal)shaSum/currentAssignment;
prabhaAverage = (Decimal)prabhaSum/currentAssignment;

//to output da result
Console.WriteLine("name\t\tgrade\n");
Console.WriteLine($"sophia\t\t{sophiaAverage} \tA+");
Console.WriteLine($"andrew\t\t{andrewAverage} \tA");
Console.WriteLine($"sha\t\t{shaAverage} \tA");
Console.WriteLine($"prabha\t\t{prabhaAverage} \tA-");
Console.ReadLine();