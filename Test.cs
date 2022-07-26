namespace Experiment;
class Test : Experiment
{
    protected int numberOfTasks;
    protected bool typeOfQuestion;

    protected internal Test() : base()
    {
        
    }
    protected internal Test(string nameOfLector, string discipline, int evalua, int numberOfTasks, bool typeOfQuestion) : base( nameOfLector, discipline, evalua)
    {
        this.numberOfTasks = numberOfTasks;
        this.typeOfQuestion = typeOfQuestion;
    }
}