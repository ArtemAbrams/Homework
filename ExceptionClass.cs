namespace Experiment;

public class ExceptionClassAlcohol
{
    public int age;

    public string name { get; set; }
    public int Age
    {
        set
        {
            if (value < 18)
            {
                throw new Exception("The age smaller than 18");
            }
            else
            {
                age = value;
            }
        }
        get
        {
            return age;
        }
    }
    public ExceptionClassAlcohol()
    {
        string name;
        long name_1;
        while (true)
        {
            try
            {
                name = Console.ReadLine();
                this.name = name;
                name_1 = Convert.ToInt32(name);
            }
            catch (Exception ex)
            {
                break;
            }
        }
        Console.WriteLine("Try-catch-finally bloc is finished");
    }
}