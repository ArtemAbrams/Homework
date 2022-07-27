namespace Experiment;
class Test : Experiment
{
    public int numberOfTasks;
    public bool typeOfQuestion;

    public Test() : base()
    {
        
    }
    public Test(string nameOfLector, string discipline, int evalua, int numberOfTasks, bool typeOfQuestion) : base( nameOfLector, discipline, evalua)
    {
        this.numberOfTasks = numberOfTasks;
        this.typeOfQuestion = typeOfQuestion;
    }

    public void Print()
    {
        Console.WriteLine("The test is start");
    }

    public void PrintInformation()
    {
        Console.WriteLine("The name of Lector" + nameOfLector + "\n " + " the discipline " + discipline + "\n" + " the value "+ evalua);
    }
}