using System;
namespace Task6
{
    class Program
    {
        static double Sum(double n, double m)
        {
            double z;
            z = (n + m) * (((n + 1) / (m + 1)) + 5 / m);

            return Math.Round(z, 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: ");
            Console.WriteLine(Sum(x, y));
        }
    }
}