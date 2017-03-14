using OO.Core.Console;
using OO.Core.Math;
using OO.Core.Verbal;
using System;
using System.Linq;

namespace App.SimpleConsoleApps
{
    public static class SumOfInts
    {
        public static void ProceduralSolution()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr_temp = Console.ReadLine().Split(' ');
            var sum = arr_temp.Select(Int32.Parse).Sum();
            Console.WriteLine(sum);
        }

        public static void OOSolution()
        {
            new ConsoleText().Get(); // Ignore first unnecessary input
            new ConsolePrinted(
                new Sum(
                    new TextsAsNumbers(
                        new SplitTexts(new ConsoleText(), " ")))).Go();
        }

    }
}
