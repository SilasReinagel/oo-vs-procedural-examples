﻿using App.SimpleConsoleApps;
using System;
using System.Threading;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NumberWeirdOrNot.OOSolution();
            }
            catch (Exception ex)
            {
                var exDetails = ex;
            }

            Thread.Sleep(500);
        }
    }
}