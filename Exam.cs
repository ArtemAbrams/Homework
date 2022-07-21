using _Experiment_;
namespace Experiment_;

class Exam : Experiment
{
    protected readonly int passingScore;

    protected Exam(string nameOfLector, string discipline, int evalua, int passingScore) : base(nameOfLector,
        discipline, evalua)
    {
        this.passingScore = passingScore;
    }

    static void PassedOrNot(ref Exam exam)
    {
        if (exam.evalua >= exam.passingScore)
            Console.WriteLine("You are Passed");
        else 
            Console.WriteLine("You are going to repassed");
    }
}