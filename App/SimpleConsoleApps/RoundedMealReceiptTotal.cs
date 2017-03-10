using OO.Core.Console;
using System;
using OO.Core.Types;
using OO.Core.Verbal;
using OO.Core.Math;

namespace App.SimpleConsoleApps
{
    public static class RoundedMealReceiptTotal
    {
        public static void ProceduralSolution()
        {
            var mealCost = Convert.ToDouble(Console.ReadLine());
            var tipPercent = Convert.ToInt32(Console.ReadLine());
            var taxPercent = Convert.ToInt32(Console.ReadLine());
            var tipAmount = mealCost * tipPercent / 100;
            var taxAmount = mealCost * taxPercent / 100;
            var totalMealCost = mealCost + tipAmount + taxAmount;
            var roundedMealCost = (int)Math.Round(totalMealCost);
            var output = $"The total meal cost is {roundedMealCost} dollars.";
            Console.WriteLine(output);
        }

        public static void OOSolution()
        {
            var mealCost = new ConsoleNumber();
            new ConsolePrinted(
                new FormattedText("The total meal cost is {0} dollars.",
                    new NumberAsText(
                        new Rounded(
                            new Sum(
                                mealCost,
                                new Percentage(new ConsoleNumber()).Of(mealCost),
                                new Percentage(new ConsoleNumber()).Of(mealCost)))))).Go();
        }
    }
}
