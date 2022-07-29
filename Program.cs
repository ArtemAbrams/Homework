using Experiment;

int x = 0;
int y = 0;
try
{
    Console.WriteLine(x / y);
}
catch (Exception ex) when (x==0 || y==0)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.TargetSite);
    Console.WriteLine("The mistake ");
}
finally
{
    Console.WriteLine("The try-catch-finally block is end");
}
Console.WriteLine("The program is finish");