using Experiment;

string name = Console.ReadLine();
try
{
    ExceptionClassAlcohol ex = new ExceptionClassAlcohol(name);
}
catch (Exception e)
{
    Console.WriteLine(e);
}
Console.WriteLine("The program is finish");