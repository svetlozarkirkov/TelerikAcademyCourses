namespace _07_PointInACircle
{
    using System;

    internal class App
    {
        private const int radius = 2;
        
        private struct Point
        {
            public double X, Y;
        }
        
        private static bool InsideCircle(Point point)
        {
            bool isInCircle = point.X*point.X + point.Y*point.Y <= (radius*radius);
            return isInCircle;
        }
        
        static void Main()
        {
            Point test = new Point();
            test.X = double.Parse(Console.ReadLine());
            test.Y = double.Parse(Console.ReadLine());
          	var distance = Math.Sqrt(Math.Pow(Math.Abs(0 - test.X), 2)
                + Math.Pow(Math.Abs(0 - test.Y), 2));
            Console.WriteLine(InsideCircle(test) ? "yes {0:F2}" : "no {0:F2}", distance);
        }
    }
}