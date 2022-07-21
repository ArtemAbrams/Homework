using _Experiment_;
namespace _Experiment;
class Test : Experiment
{
    protected int numberOfTasks;
    protected bool typeOfQuestion;
    protected Test(string nameOfLector, string discipline, int evalua, int numberOfTasks, bool typeOfQuestion) : base( nameOfLector, discipline, evalua)
    {
        this.numberOfTasks = numberOfTasks;
        this.typeOfQuestion = typeOfQuestion;
    }
}