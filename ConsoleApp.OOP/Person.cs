using System;

namespace ConsoleApp.OOP
{
  public class Person
  {
    public string SecondName { get; private set; }
    public string Name { get; private set; }
    public Person (string secondName, string name)
    {
      SecondName = secondName;
      Name = name;
    }
  }
}
