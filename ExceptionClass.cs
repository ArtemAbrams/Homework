namespace Experiment;

public class ExceptionClassAlcohol
{
    public int age;

    public string name
    {
        get
        {
            return name;
        }
        set
        {
            try
            {
                name = value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public int Age
    {
        set
        {
            if (Age < 18)
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
        Console.WriteLine("Enter the name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the age");
        int age=int.Parse(Console.ReadLine());
        while (true)
        {
            try
            {
                this.name = name;
                if (age < 18)
                {
                    throw new Exception("The agg smaller than 18");
                }
                else
                {
                    this.age = age;
                }

                break;
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.Message);
            }
        }
    }
}