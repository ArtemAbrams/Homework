namespace Experiment;

public class ExceptionClassAlcohol
{
    public int age;
    private char[] numeric = new char [10] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'}; 
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
    public ExceptionClassAlcohol(string name)
    {
        foreach (var i in name)
        {
            foreach (var j in numeric)
            {
                if (i == j)
                {
                    throw new Exception("You use numeric");
                    break;
                }
            }
        }
    }
}