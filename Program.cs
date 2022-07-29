using Experiment;

try
{
    int x = 0;
    int y = 0;
    Console.WriteLine(x / y);
}
catch 
{
    Console.WriteLine("The mistake ");
}
finally
{
    Console.WriteLine("The try-catch-finally block is end");
}
Console.WriteLine("The program is finish");