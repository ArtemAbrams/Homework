namespace Hum
{
   class Human
    {
        protected  string name;
        protected  string surname;
        protected  int age;

        protected internal Human()
        {
            
        }
        protected internal Human(string name, string surname, int age)
        {
            this.name = name;
            this.age = age;
            this.surname = surname ?? "Undefine";
            Console.WriteLine("The Human class");
        }
    }
}