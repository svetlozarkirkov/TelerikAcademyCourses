namespace _09_Trapezoids
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = Math.Round(height*((a + b)/2), 7);
            Console.WriteLine("{0:F7}", area);
        }
    }
}