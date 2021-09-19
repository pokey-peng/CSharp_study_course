// compile：csc /r:Person.dll ClassCompareTest.cs  ->  ClassCompareTest.exe
using System;
namespace CSharpBook.Chapter06
{
  class ClassCompareTest
  {
    static void Main(string[] args)
    {
        Person personA = new Person ("ZhangSan",25); //创建对象1
        Person personB = new Person ("LiSi",18);     //创建对象2
        if (personA == personB)        //比较对象
        {
            Console.WriteLine("personA与personB相同。");
        }else{
            Console.WriteLine("personA与personB不同。");
        }
        personB = personA; 
        if (personA == personB)       //比较对象
        {
            Console.WriteLine("personA与personB相同。");
        }else{
            Console.WriteLine("personA与personB不同。");
        }
        personB.name = "WangWu"; 
        Console.WriteLine("PersonB’s name: {0}", personB.name);
        Console.WriteLine("PersonA’s name: {0}", personA.name);
        Console.ReadKey();
    }
  }
}
