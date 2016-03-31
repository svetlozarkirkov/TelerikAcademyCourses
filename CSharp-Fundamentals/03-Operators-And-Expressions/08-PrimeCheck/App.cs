namespace _08_PrimeCheck
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(inputNumber).ToString().ToLowerInvariant());

        }
        private static bool IsPrime(int candidate)
        {
            if (candidate < 0)
            {
                return false;
            }

            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (var i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}