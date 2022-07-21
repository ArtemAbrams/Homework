using Doct;
using Hum;
/*string surname = null;
Doctor doctor = new Doctor("Ton", surname, 13, "56784");
doctor.Print();*/
Human obj = new Doctor();
if (obj is Human human)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
((Doctor)obj).Print();