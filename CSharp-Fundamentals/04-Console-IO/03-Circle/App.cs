namespace _03_Circle
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var circleRadius = double.Parse(Console.ReadLine());
            var circlePerimeter = Math.Round(2*Math.PI*circleRadius, 2);
            var circleArea = Math.Round(Math.PI * circleRadius * circleRadius, 2);
            Console.WriteLine("{0:F2} {1:F2}", circlePerimeter, circleArea);
        }
    }
}