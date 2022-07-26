namespace Experiment;

class Car: Transport
{
    internal string name;
    internal string mark;
    internal override string code
    {
        get
        {
            return base.code;
        }
        set
        {
            Console.WriteLine("The value");
            base.code = value;
        }
    }

    internal Car (int price, string mark, string name) : base(price)
    {
        this.name = name;
        this.mark = mark;
    }

    public override void Print()
    {
        Console.WriteLine("The car " + name + "is driving");
    }
}