using OO.Core.Console;
using OO.Core.Types;
using OO.Core.Verbal;
using OO.Core.Math;
using System;

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
            new ConsolePrinted(
                new MealCostExpression(
                    mealCost: new ConsoleNumber(), 
                    tipRate: new ConsoleNumber(),
                    taxRate: new ConsoleNumber())).Go();
        }
    }

    internal class MealCostExpression : Text
    {
        private readonly Number _mealCost;
        private readonly Number _tipRate;
        private readonly Number _taxRate;

        public MealCostExpression(Number mealCost, Number tipRate, Number taxRate)
        {
            _mealCost = mealCost;
            _tipRate = tipRate;
            _taxRate = taxRate;
        }

        public override string Get()
        {
            return new FormattedText("The total meal cost is {0} dollars.",
                new NumberAsText(
                    new Rounded(
                        new Sum(_mealCost, 
                            new Percentage(_tipRate).Of(_mealCost), 
                            new Percentage(_taxRate).Of(_mealCost))))).Get();
        }
    }
}
