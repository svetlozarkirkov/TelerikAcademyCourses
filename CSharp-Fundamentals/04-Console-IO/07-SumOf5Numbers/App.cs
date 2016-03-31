namespace _07_SumOf5Numbers
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var sum = 0;
            for (var i = 0; i < 5; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}