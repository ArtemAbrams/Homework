namespace Experiment;
class Experiment
{
    protected string nameOfLector;
    protected string discipline;
    protected int evalua;

    protected Experiment()
    {
            
    }
    protected Experiment(string nameOfLector, string discipline, int evalua)
    {
        this.nameOfLector = nameOfLector;
        this.discipline = discipline;
        this.evalua = evalua;
    }
}