namespace _17_SpiralMatrix
{
    using System;

    internal class App
    {
        private static void Main()
        {
            System.Console.SetWindowSize(100, 30);
            var n = int.Parse(Console.ReadLine());
            Console.Clear();
            var matrix = new int[n, n];
            var row = 0;
            var col = 0;
            var value = 1;

            while (value <= n * n)
            {
                while (col < matrix.GetLength(0) && matrix[col, row] == 0)
                {
                    matrix[row, col++] = value;
                    value++;
                }

                col--;
                row++;

                while (row < matrix.GetLength(1) && matrix[row, col] == 0)
                {
                    matrix[row++, col] = value;
                    value++;
                }

                row--;
                col--;

                while (col >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col--] = value;
                    value++;
                }

                col++;
                row--;

                while (row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row--, col] = value;
                    value++;
                }

                col++;
                row++;
            }

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j * 5, i * 2);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}