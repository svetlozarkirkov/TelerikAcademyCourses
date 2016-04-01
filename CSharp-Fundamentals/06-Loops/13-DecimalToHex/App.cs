namespace _13_DecimalToHex
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var inputNumber = long.Parse(Console.ReadLine());
            PrintHexValue(inputNumber);
            Console.WriteLine();
        }

        private static void PrintHexValue(long n)
        {
            if (n == 0)
            {
                return;
            }

            var r = n % 16;
            n = n / 16;
            PrintHexValue(n);

            switch (r)
            {
                case 10:
                    Console.Write("A");
                    break;
                case 11:
                    Console.Write("B");
                    break;
                case 12:
                    Console.Write("C");
                    break;
                case 13:
                    Console.Write("D");
                    break;
                case 14:
                    Console.Write("E");
                    break;
                case 15:
                    Console.Write("F");
                    break;
                default:
                    Console.Write(r);
                    break;
            }
        }
    }
}