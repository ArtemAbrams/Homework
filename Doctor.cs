using System.Runtime.InteropServices;
using Hum;
namespace Doct;
class Doctor: Human
{
    protected string code;

    internal Doctor()
    {
        
    }
    internal Doctor(string name, string surname, int age, string code) :  base(name, surname,age)
    {
        this.code = code;
        Console.WriteLine("The Doctor class");
    }

    internal void Print()
    {
        Console.WriteLine("The date " + age +" " + name + " " + code + " "+ surname);
    }
}