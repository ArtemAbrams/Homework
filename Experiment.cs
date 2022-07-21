namespace _Experiment_;
class Experiment
{
    protected string nameOfLector;
    protected string discipline;
    protected int evalua;
    protected Experiment(string nameOfLector, string discipline, int evalua)
    {
        this.nameOfLector = nameOfLector;
        this.discipline = discipline;
        this.evalua = evalua;
    }
}