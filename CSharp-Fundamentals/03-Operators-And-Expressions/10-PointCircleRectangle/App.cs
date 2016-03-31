namespace _10_PointCircleRectangle
{
    using System;

    internal class App
    {
        private const double CircleRadius = 1.5;
        private const double CirclePosition = 1;

        private struct Point
        {
            public double X, Y;
        }

        private static bool InsideCircle(Point point)
        {
            var isInCircle = (point.X - CirclePosition) * (point.X - CirclePosition) +
                (point.Y - CirclePosition) * (point.Y - CirclePosition)
                <= (CircleRadius * CircleRadius);

            return isInCircle;
        }

        private static bool InsideRectangle(Point point)
        {
            var isInsideRectangle = (point.X >= -1 && point.X <= 5)
                && (point.Y >= -1 && point.Y <= 1);

            return isInsideRectangle;
        }

        private static void Main()
        {
            var test = new Point
            {
                X = double.Parse(Console.ReadLine()),
                Y = double.Parse(Console.ReadLine())
            };
            var isInsideCircle = InsideCircle(test);
            var isInsideRectangle = InsideRectangle(test);

            Console.WriteLine("{0} circle {1} rectangle",
                isInsideCircle ? "inside" : "outside",
                isInsideRectangle ? "inside" : "outside");
        }
    }
}