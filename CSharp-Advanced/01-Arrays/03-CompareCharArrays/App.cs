namespace _03_CompareCharArrays
{
    using System;
    using System.Collections.Generic;

    internal class App
    {
        private static void Main()
        {
            var firstArray = Console.ReadLine().ToCharArray();
            var secondArray = Console.ReadLine().ToCharArray();
            var comparer = new LexicographicCharArrayComparer();
            var result = comparer.Compare(firstArray, secondArray);
            if (result < 0)
            {
                Console.WriteLine("<");
            }
            else if (result == 0)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine(">");
            }
        }

        private class LexicographicCharArrayComparer : Comparer<char[]>
        {
            /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
            public override int Compare(char[] x, char[] y)
            {
                if (x == null || y == null)
                {
                    return Default.Compare(x, y);
                }

                var lengthComp = x.Length.CompareTo(y.Length);
                return lengthComp != 0 ? lengthComp : StringComparer.Ordinal.Compare(new string(x), new string(y));
            }
        }
    }
}