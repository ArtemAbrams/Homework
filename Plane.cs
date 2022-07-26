namespace Experiment;

class Plane: Transport
{
  public int speed { get; set; }
  public string name { get; set; }
  public string type;

  public Plane(int price) : base(price)
  {
    this.speed = speed;

    this.name = name;
    
  }

  public new void Print()
  {
    Console.WriteLine("The plane " + name + " fly " + " the speed is " + speed);
  }
}