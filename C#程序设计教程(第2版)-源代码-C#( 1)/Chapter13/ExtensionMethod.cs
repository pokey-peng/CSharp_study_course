//ExtensionMethod.cs
//compile£ºcsc /t:library ExtensionMethod.cs  --> ExtensionMethod.dll
using System;
namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', ',', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
