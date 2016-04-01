namespace _11_BinaryToDecimal
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var binaryString = Console.ReadLine();
            var result = 0L;
            for (var i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[binaryString.Length - i - 1] == '0')
                {
                    continue;
                }

                result += (long)Math.Pow(2, i);
            }

            Console.WriteLine(result);
        }
    }
}