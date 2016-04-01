namespace _05_Calculate
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var sum = 1d;

            for (var i = 1; i <= n; i++)
            {
                sum += CalculateFactorial(i) / Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}", sum);
        }

        private static double CalculateFactorial(int number)
        {
            double fact = number;
            for (var i = number - 1; i >= 2; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}