using System;
namespace CSharpBook.Chapter07
{
  class Person
  {
    public const int RETIREMENT_AGE = 60;
    public const int RETIREMENT_AGE_DELAY = RETIREMENT_AGE + 10;
    string name; int age;
  }
  public class ConstantFieldTest
  {
    public static void Main()
    {
      Console.WriteLine("AGE = {0}£¬AGE_DELAY = {1}", Person.RETIREMENT_AGE, Person.RETIREMENT_AGE_DELAY);
      Console.ReadLine();
    }
  }
}
