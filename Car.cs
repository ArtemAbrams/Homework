namespace Experiment;

class Car: Transport
{
    public string name;
    public string mark;
    public override string code
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

    public Car (int price, string mark, string name) : base(price)
    {
        this.name = name;
        this.mark = mark;
    }

    public override void Print()
    {
        Console.WriteLine("The car " + name + "is driving");
    }
}