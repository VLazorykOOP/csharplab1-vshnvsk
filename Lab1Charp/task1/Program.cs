using System;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double z = Math.Sqrt(Math.Abs(x) * Math.Abs(y));
            Console.WriteLine("Answer: " + Math.Round(z, 2));
        }
    }
}