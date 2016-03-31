namespace _01_OddOrEven
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());
            var result = inputNumber % 2 == 0 ? "even" : "odd";
            Console.WriteLine("{0} {1}", result, inputNumber);
        }
    }
}