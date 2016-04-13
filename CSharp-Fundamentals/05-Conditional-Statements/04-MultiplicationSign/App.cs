namespace _04_MultiplicationSign
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var negativeCount = 0;
            var isZero = false;

            for (var i = 0; i < 3; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());

                if (currentNumber.Equals(0))
                {
                    isZero = true;
                }
                else if (currentNumber < 0)
                {
                    negativeCount++;
                }
            }

            if (isZero)
            {
                Console.WriteLine("0");
            }
            else if (negativeCount == 1 || negativeCount == 3)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}