using System;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number for check: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 10 == 7)
            {
                Console.WriteLine("Yes, your number ended on 7");
            }
            else
            {
                Console.WriteLine("Sorry(, but no");
            }
        }
    }
}