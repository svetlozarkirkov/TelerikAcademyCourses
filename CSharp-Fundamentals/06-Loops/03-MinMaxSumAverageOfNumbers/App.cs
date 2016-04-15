namespace _03_MinMaxSumAverageOfNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbersList = new List<double>();
            for (var i = 0; i < n; i++)
            {
                numbersList.Add(double.Parse(Console.ReadLine()));
                //numbersList.Add(-10000);
            }

            Console.WriteLine("min={0:.00}\nmax={1:.00}\nsum={2:.00}\navg={3:.00}",
                numbersList.Min(),
                numbersList.Max(),
                numbersList.Sum(),
                numbersList.Average());
        }
    }
}