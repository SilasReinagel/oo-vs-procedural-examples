using OO.Core.Console;
using OO.Core.Math;
using System;

namespace App.SimpleConsoleApps
{
    public static class MultipliersOneThruTen
    {
        public static void ProceduralSolution()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
        }

        public static void OOSolution()
        {
            var n = new ConsoleNumber();
            new ConsolePrinted(
                new Range(1, 10).Texts(x => $"{n} x {x} = {n * x}")).Go();
        }
    }
}
