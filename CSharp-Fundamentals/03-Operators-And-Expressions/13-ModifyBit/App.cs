namespace _13_ModifyBit
{
    using System;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            var numberAsBinaryString = Convert.ToString(uint.Parse(Console.ReadLine()), 2);
            var position = int.Parse(Console.ReadLine());
            var bitValue = int.Parse(Console.ReadLine());

            var binaryList = numberAsBinaryString.PadLeft(64, '0').ToCharArray().ToList();
            binaryList.Reverse();
            binaryList[position] = bitValue == 1 ? '1' : '0';
            binaryList.Reverse();
            Console.WriteLine(Convert.ToUInt64(string.Join("", binaryList),2));
        }
    }
}