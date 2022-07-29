using Experiment;

int x = 0;
int y = 0;
try
{
    Console.WriteLine(x / y);
}
catch when (x==0 || y==0)
{
    Console.WriteLine("The mistake ");
}
finally
{
    Console.WriteLine("The try-catch-finally block is end");
}
Console.WriteLine("The program is finish");