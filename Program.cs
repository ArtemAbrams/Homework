using Experiment;

int evalue = int.Parse(Console.ReadLine());
int passsingScore = int.Parse(Console.ReadLine());
Exam exam = new Exam("Ivan", "Mathematical analysis", evalue, passsingScore);
Exam.PassedOrNot(ref exam);
Console.WriteLine();