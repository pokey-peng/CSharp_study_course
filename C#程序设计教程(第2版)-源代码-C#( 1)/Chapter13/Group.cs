using System; using System.Linq;
namespace CSharpBook.Chapter13
{
    class Group
    {
        static void Main()
        {
            int[] numbers = { 35, 44, 200, 84, 3987, 4, 199, 329, 446, 208 };
            var q1 = from n in numbers group n by n % 2;
            foreach (var group in q1)
            {
                Console.Write(group.Key == 0 ? "\n偶数:" : "\n奇数:");
                foreach (int i in group) Console.Write("{0} ", i);
            };
            var q2 = numbers.GroupBy(n => n % 2);
            foreach (var group in q1)
            {
                Console.Write(group.Key == 0 ? "\n偶数:" : "\n奇数:");
                foreach (int i in group) Console.Write("{0} ", i);
            };
            Console.ReadKey();
        }
    }
}
