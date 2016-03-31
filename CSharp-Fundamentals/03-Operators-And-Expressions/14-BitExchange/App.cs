namespace _14_BitExchange
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var number = uint.Parse(Console.ReadLine());
            var smallBits = number & (7 << 3); // 3,4,5
            var largeBits = number & (7 << 24); // 24,25,26
            number = (number ^ (smallBits | largeBits)) | (largeBits >> 21) | (smallBits << 21);
            Console.WriteLine(number);
        }
    }
}