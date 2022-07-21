using _Experiment_;
namespace Experiment_;

class Exam: Experiment
{
    protected int passingScore;

    protected Exam(string nameOfLector, string discipline, int evalua, int passingScore) : base(nameOfLector,
        discipline, evalua)
    {
        this.passingScore = passingScore;
    }
}