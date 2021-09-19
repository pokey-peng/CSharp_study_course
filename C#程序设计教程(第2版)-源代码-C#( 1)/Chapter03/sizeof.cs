// compile£ºcsc /unsafe sizeof.cs  -> sizeof.exe
using System;
namespace CSharpBook.Chapter03
{
    class MainClass
    {
        unsafe static void Main()
        {
            Console.WriteLine("The size of short is {0}.", sizeof(short));
            Console.WriteLine("The size of int is {0}.", sizeof(int));
            Console.WriteLine("The size of long is {0}.", sizeof(long)); Console.ReadKey();
        }
    }
}
