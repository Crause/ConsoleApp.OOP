using System;

namespace ConsoleApp.OOP
{
  class Program
  {
    static void Main(string[] args)
    {
      Person person1 = new Person();
      //person1.SetName("Vladimir");
      person1.Name = "Vladimir";
      //Console.WriteLine(person1.Name);

      person1.SecondName = "Kuzmin";
      //Console.WriteLine(person1.SecondName);

      Console.WriteLine(person1.FullName);
      Console.WriteLine(person1.ShortName);

      Console.ReadLine();
    }
  }
}
