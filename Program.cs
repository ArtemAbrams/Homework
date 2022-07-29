using Experiment;

void Numeric(int x)
{
    if (x >= 0)
    {
        throw new Exception("The positive numeric");
    }
}
try
{   
    int x = int.Parse(Console.ReadLine());
    Numeric(x);
   /* x = int.Parse(Console.ReadLine());
    if (x >= 0)
    {
        throw new Exception("The positive numeric");
    }*/
    
}
catch (Exception ex) 
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.TargetSite);
}
Console.WriteLine("The program is finish");