namespace _02_MoonGravity
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var weightOnEarth = double.Parse(Console.ReadLine());
            var weightOnMoon = weightOnEarth*0.17;
            Console.WriteLine("{0:F3}", Math.Round(weightOnMoon, 3));
        }
    }
}