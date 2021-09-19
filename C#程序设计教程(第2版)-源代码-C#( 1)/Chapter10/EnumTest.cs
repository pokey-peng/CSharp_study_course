using System;
enum Color { Red, Green, Blue }
public class EnumTest
{
    public static void Main()
    {
        Color color1 = Color.Blue;
        if (color1 == Color.Red) { Console.WriteLine("color1 is red"); }
        else { Console.WriteLine("color1 is not red"); }
        Color color2 = Color.Red;
        switch (color2)
        {
            case Color.Red:
                Console.WriteLine("color2 is red"); break;
            case Color.Green:
                Console.WriteLine("color2 is green"); break;
            case Color.Blue:
                Console.WriteLine("color2 is blue"); break;
        }
        Console.WriteLine("Color.Green = {0}", Color.Green);
        Console.WriteLine("Color.Green = {0}", (int)Color.Green);
        Console.ReadKey();
    }
}
