namespace _12_DecimalToBinary
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var inputNumber = long.Parse(Console.ReadLine());

            if (inputNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var result = string.Empty;

            while (inputNumber > 0)
            {
                var remainder = inputNumber % 2;
                inputNumber /= 2;
                result = remainder + result;
            }

            Console.WriteLine(result);
        }
    }
}