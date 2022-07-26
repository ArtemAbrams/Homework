namespace Experiment;

abstract class Transport
{ 
    internal readonly int price;

    internal virtual string code
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
    internal Transport(int price)
    {
        this.price = price;
    }

    public virtual void Print()
    {
        Console.WriteLine("The transport is move");
    }
}