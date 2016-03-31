namespace _07_PointInACircle
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            const int radius = 2;

            var distance = Math.Sqrt(Math.Pow(Math.Abs(0 - x), 2)
                + Math.Pow(Math.Abs(0 - y), 2));

            var isInsideTheCircle = x <= radius && y <= radius;
            Console.WriteLine(isInsideTheCircle ? "yes {0:F2}" : "no {0:F2}", distance);
        }
    }
}