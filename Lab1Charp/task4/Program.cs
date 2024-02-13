using System;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a suit number: \n" +
                "1. chervil\n" +
                "2. cross\n" +
                "3. peak\n" +
                "4. tambourine");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a card number(from 6 to 14): ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(y switch
            {
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                10 => "ten",
                11 => "jack",
                12 => "lady",
                13 => "king",
                14 => "ace",
                _ => "Error"
            });

            Console.WriteLine(x switch
            {
                1 => "chervil",
                2 => "cross",
                3 => "peak",
                4 => "tambourine",
                _ => "Error"
            });
        }
    }
}
