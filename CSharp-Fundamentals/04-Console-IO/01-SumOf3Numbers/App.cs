namespace _01_SumOf3Numbers
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var sum = 0.0;
            for (var i = 0; i < 3; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}