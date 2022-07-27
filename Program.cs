using Experiment;
string id=Console.ReadLine(), name=Console.ReadLine(), phoneNumber=Console.ReadLine();
string nameOfLector=Console.ReadLine(), discipline=Console.ReadLine();
int evalua=int.Parse(Console.ReadLine()), numberOfTasks=int.Parse(Console.ReadLine());
bool typeOfQuestion=bool.Parse(Console.ReadLine());
Test test = new Test(nameOfLector, discipline, evalua, numberOfTasks, typeOfQuestion);
Person<Test, string> person = new Person<Test, string>(test, name, id, phoneNumber); 
person.Print();