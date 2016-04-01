namespace _04_MultiplicationSign
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var isNegative = false;
            var isZero = false;
            for (var i = 0; i < 3; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());

                if (currentNumber < 0)
                {
                    isNegative = true;
                }
                else if (currentNumber == 0)
                {
                    isZero = true;
                }
            }
            if (!isZero && !isNegative)
            {
                Console.WriteLine("+");
            }
            else if (!isZero && isNegative)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}