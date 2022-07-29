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
    }
}