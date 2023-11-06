using System;

namespace Program
{
    public class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main()
        {
            int a, b;

            Console.Write("a = ? ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ? ");
            b = Convert.ToInt32(Console.ReadLine());

            int c = Sum(a, b);
            Console.WriteLine("c = " + c);

            Console.ReadLine();
        }
    }
}