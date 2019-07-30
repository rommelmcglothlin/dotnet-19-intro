using System;

namespace PrimitiveTypes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      //   var ogColor = Console.ForegroundColor;
      //   Console.ForegroundColor = ConsoleColor.White;


      Console.WriteLine("Welcome to Dotnet 101!");
      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      Console.WriteLine($"Welcome to class, {name}");
      Console.WriteLine($"There are {name.Length}  letters in your name");
      Console.WriteLine("How old are you?");
      string strAge = Console.ReadLine();
      Int32.TryParse(strAge, out int age);
      System.Console.WriteLine($"In ten years {name} will be {age + 10}");





      // Console.WriteLine("24" + 10);







      //   int age = 24;
      //   decimal bankAccount = 10.75m;
      //   float sistersAge = 22f;
      //   bool imTrue = true;

    }
  }
}
