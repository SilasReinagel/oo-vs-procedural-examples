using OO.Core.Console;
using OO.Core.Math;
using OO.Core.Types;
using OO.Core.Verbal;
using System;

namespace App.SimpleConsoleApps
{
    public static class NumberWeirdOrNot
    {
        public static void ProceduralSolution()
        {
            var number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 1 || (number >= 6 && number <= 20))
                Console.WriteLine("Weird");
            else
                Console.WriteLine("Not Weird");
        }

        public static void OOSolution()
        {
            var number = new ConsoleNumber();
            new ConsolePrinted(
                new Conditional<Text>(new IsOdd(number) || new IsInRangeInclusive(number, 6, 20), 
                    "Weird", 
                    "Not Weird")).Go();
        }
    }
}
