using System;

namespace ConsoleApp.OOP
{
  class Program
  {
    static void Main(string[] args)
    {
      Person person1 = new Person();
      person1.FirstName = "Vladimir";
      person1.LastName = "Kuzmin";

      var person2 = new Person();
      person2.FirstName = "Vasiliy";
      person2.LastName = "Pupkin";

      var doctor1 = new Doctor();
      doctor1.FirstName = "Ai";
      doctor1.LastName = "Bolit";
      doctor1.Specialization = "101010";


      Console.WriteLine(doctor1.FirstName);
      Console.WriteLine(doctor1.Specialization);

      Person p = doctor1;

      Console.WriteLine(p.FirstName);

      Doctor d = (Doctor)p;

      Console.WriteLine(d.FirstName);
      Console.WriteLine(d.Specialization);


      Console.ReadLine();
    }
  }
}
