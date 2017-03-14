using OO.Core.Console;
using OO.Core.Math;
using System;

namespace App.SimpleConsoleApps
{
    public static class SumOfTwoInts
    {
        public static void ProceduralSolution()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = val1 + val2;
            Console.WriteLine(sum);
        }

        public static void OOSolution()
        {
            new ConsolePrinted(
                new Sum(new ConsoleNumber(), new ConsoleNumber())).Go();
        }
    }
}
