namespace Experiment;

abstract class Transport
{ 
    public readonly int price;

    public virtual string code
    {
        get
        {
            return code;
        }
        set
        {
            code = value;
        }
    }
    public Transport(int price)
    {
        this.price = price;
    }

    public virtual void Print()
    {
        Console.WriteLine("The transport is move");
    }
}