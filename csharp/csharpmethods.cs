//C# Methods
using System;
namespace MyApplication
{  
  class Csharpmethods
  {
    static void MyMethod()
    {
      int a,b;
      Console.WriteLine("Enter The First Number: ");
      a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter The Second Number: ");
      b =  Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("The Output is: ", Math.Pow(a, b));
      Console.WriteLine(Math.Pow(a, b)); // math power
    }   
    static void Main(string[] args)
    {
      MyMethod();
    }
  }
}
