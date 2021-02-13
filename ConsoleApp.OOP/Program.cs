using System;

namespace ConsoleApp.OOP
{
  class Program
  {
    static void Main(string[] args)
    {
      Person person1 = new Person("Kuzmin", "Vladimir");
      Console.WriteLine(person1.SecondName + " " + person1.Name);

      Console.ReadLine();
    }
  }
}
