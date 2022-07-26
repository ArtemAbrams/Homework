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
}