using Experiment;

ExceptionClassAlcohol ex = new ExceptionClassAlcohol();
try
{
    ex.Age = 15;
}
catch (Exception e)
{
    Console.WriteLine(e);
}
Console.WriteLine("The program is finish");