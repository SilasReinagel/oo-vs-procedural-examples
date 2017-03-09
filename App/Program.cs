using App.SimpleConsoleApps;
using System.Threading;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfTwoInts.ProceduralSolution();
            SumOfTwoInts.OOSolution();

            Thread.Sleep(500);
        }
    }
}