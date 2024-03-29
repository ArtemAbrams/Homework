﻿namespace Experiment;
class Person<T, P> where T : Test
{
  public T test;
  public P id;
  public P phoneNumber;
  public string name;

  public Person(T test, string name, P id, P phoneNumber)
  {
    this.test = test;
    this.id = id;
    this.phoneNumber = phoneNumber;
    this.name = name;
  }

  public void Print()
  {
    Console.WriteLine("Name " + name + "\n" + " Id" + id + "\n" +  "Phone number " + phoneNumber);
    this.test?.PrintInformation();
  }
}

