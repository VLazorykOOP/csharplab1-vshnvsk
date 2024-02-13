using System;
namespace Task5
{
    class Program
    {
        static double Sum(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Result: ");
            Console.WriteLine(Sum(x, y));
        }
    }
}