//C# Methods
using System;
namespace CsharpMethods
{  
   static class CsharpMethods
  {
    static void CsharpMethods()
    {
      int a,b;
      Console.WriteLine("Enter The First Number: ");
      a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter The Second Number: ");
      b =  Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("The Output is: ");
      Console.WriteLine(Math.Pow(a, b));
    }   
    static void Main(string[] args)
    {
      CsharpMethods();
    }
  }
}
