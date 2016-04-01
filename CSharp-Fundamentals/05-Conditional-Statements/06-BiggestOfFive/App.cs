namespace _06_BiggestOfFive
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var biggest = double.MinValue;
            for (var i = 0; i < 5; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());

                if (currentNumber > biggest)
                {
                    biggest = currentNumber;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}