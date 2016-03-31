namespace _15_BitSwap
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var number = uint.Parse(Console.ReadLine());
            var firstStartPosition = int.Parse(Console.ReadLine());
            var secondStartPosition = int.Parse(Console.ReadLine());
            var quantityOfBits = int.Parse(Console.ReadLine());

            var numberAsBinaryString = Convert.ToString(number, 2).PadLeft(32, '0');
            var numberAsBinaryArray = new int[32];
            for (var i = 0; i < numberAsBinaryString.Length; i++)
            {
                numberAsBinaryArray[i] = Convert.ToInt32(numberAsBinaryString[i].ToString());
            }
            Array.Reverse(numberAsBinaryArray);
            for (var i = 0; i < quantityOfBits; i++)
            {
                var temp = numberAsBinaryArray[firstStartPosition];
                numberAsBinaryArray[firstStartPosition] = numberAsBinaryArray[secondStartPosition];
                numberAsBinaryArray[secondStartPosition] = temp;
                firstStartPosition++;
                secondStartPosition++;
            }
            Array.Reverse(numberAsBinaryArray);
            var result = string.Join(string.Empty, numberAsBinaryArray);
            Console.WriteLine(Convert.ToUInt32(result, 2));
        }
    }
}