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
             new ConsolePrinted(
                new IsWeirdText(
                    new ConsoleNumber())).Go();
        }

        private class IsWeirdText : Text
        {
            private readonly Number _number;

            public IsWeirdText(Number number)
            {
                _number = number;
            }

            public override string Get()
            {
                return new Conditional<Text>(new IsOdd(_number) || new IsInRangeInclusive(_number, 6, 20),
                    "Weird",
                    "Not Weird").Get();
            }
        }
    }
}
