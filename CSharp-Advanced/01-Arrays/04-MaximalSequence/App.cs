namespace _04_MaximalSequence
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            var maxLength = 1;
            for (var i = 0; i < n; i++)
            {
                var currentNum = array[i];
                var currentLength = 1;

                for (var j = i + 1; j < n; j++)
                {
                    if (!array[j].Equals(currentNum))
                    {
                        break;
                    }

                    currentLength++;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            Console.WriteLine(maxLength);
        }
    }
}