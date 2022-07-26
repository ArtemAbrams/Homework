namespace Experiment;
class Exam : Experiment
{
    public readonly int? passingScore;

    public Exam(string nameOfLector, string discipline, int evalua, int passingScore) : base(nameOfLector,
        discipline, evalua)
    {
        this.passingScore = passingScore;
    }

    public static void PassedOrNot(ref Exam exam)
    {
        if (exam.evalua >= exam.passingScore)
            Console.WriteLine("You are Passed");
        else 
            Console.WriteLine("You are going to repassed");
    }
}