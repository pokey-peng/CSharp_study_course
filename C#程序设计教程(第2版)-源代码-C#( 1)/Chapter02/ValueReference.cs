using System;
namespace CSharpBook.Chapter02
{
	  class Class1
	  {
	    public int Value = 0;
	  }
	  class ValueReference
	  {
	    static void Main() 
	    {    
	        int val1 = 0; int val2 = val1; val2 = 123;
	        Class1 ref1 = new Class1();Class1 ref2 = ref1; ref2.Value = 123;
	        Console.WriteLine("Values: {0}, {1}", val1, val2);
	        Console.WriteLine("Refs: {0}, {1}", ref1.Value, ref2.Value); Console.ReadKey();
	      }
	  }
}
