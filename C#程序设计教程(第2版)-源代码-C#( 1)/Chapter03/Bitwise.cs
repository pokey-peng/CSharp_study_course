using System;
namespace CSharpBook.Chapter03
{
    class BitwiseTest
    {
        static void Main()
        { //×óÒÆÔËËã·û (<<) 
            int i = 1;
            long lg = 1;
            Console.WriteLine("0x{0:x}", i << 33);
            Console.WriteLine("0x{0:x}", lg << 33);
         //ÓÒÒÆÔËËã·û (>>) 
            uint   ui = 0xffffffff;
            ulong ulg = 0xffffffff;
            Console.WriteLine("0x{0:x}", ui >> 33);
            Console.WriteLine("0x{0:x}", ulg >> 33);
            Console.ReadKey(); 
        }
    }
}
