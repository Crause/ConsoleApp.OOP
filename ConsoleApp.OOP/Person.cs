using System;

namespace ConsoleApp.OOP
{
  public class Person
  {
    public string SecondName { get; set; }
    public string Name { get; set; }
    public string FullName
    {
      get 
      {
        return $"{Name} {SecondName}";
      }
    }
    public string ShortName
    {
      get {
        return $"{SecondName} {Name[0]}.";
      }
    }
    /*
    private string _name;
    public string Name
    {
      get 
      {
        return _name;
      }
      set 
      {
        if (string.IsNullOrWhiteSpace(value))
        {
          throw new ArgumentNullException("Имя не может быть пустым");
        }
        _name = value;
      }
    }
    */
    /*
    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      if(string.IsNullOrWhiteSpace(name))
      {
        throw new ArgumentNullException("Имя не может быть пустым");
      }
      _name = name;
    }
    */
  }
}
