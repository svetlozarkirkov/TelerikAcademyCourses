namespace _13_ModifyBit
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var number = uint.Parse(Console.ReadLine());
            var position = int.Parse(Console.ReadLine());
            var bitValue = int.Parse(Console.ReadLine());

            var mask = 0L;
            var numberAfter = 0L;

            if (bitValue == 1)
            {
                mask = 1 << position;
                numberAfter = number | mask;
            }
            else
            {
                mask = ~(1 << position);
                numberAfter = number & mask;
            }

            Console.WriteLine(numberAfter);
        }
    }
}