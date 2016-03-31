namespace _09_SumOfNNumbers
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var sum = 0.0;
            for (var i = 0; i < count; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}