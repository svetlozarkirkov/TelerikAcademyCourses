namespace _03_DivideBy7And5
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());
            var isDivisibleWithoutRemainder = inputNumber%5 == 0 && inputNumber%7 == 0;
            Console.WriteLine(
                "{0} {1}",
                isDivisibleWithoutRemainder.ToString().ToLowerInvariant(),
                inputNumber);
        }
    }
}