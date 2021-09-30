using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentDayInYear = 293;
            bool isLeapYear = false;

            bool isWinter =
                !isLeapYear & (currentDayInYear >= 335 | currentDayInYear <= 59)
                |
                isLeapYear & (currentDayInYear >= 336 | currentDayInYear <= 60);

            Console.WriteLine("Текущее время года зима : " + isWinter);

            var a = 6;
            var b = 7;

            var c = a != b ? a + b : b;

            Console.WriteLine(c);

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");

                Console.ReadKey();
            }
        }
    }
}

