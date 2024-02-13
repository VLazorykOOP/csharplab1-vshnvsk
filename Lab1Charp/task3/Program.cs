using System;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x * x + y * y > 9 && x * x + y * y < 49)
            {
                Console.WriteLine("Result: Inside");
            }
            else if (x * x + y * y > 9 || x * x + y * y < 49)
            {
                Console.WriteLine("Result: Outside");
            }
            else
            {
                Console.WriteLine("Result: On line");
            }
        }
    }
}