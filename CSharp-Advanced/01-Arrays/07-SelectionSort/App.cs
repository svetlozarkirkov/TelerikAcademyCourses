namespace _07_SelectionSort
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
            var sortedArray = SelectionSort(array);
            foreach (var num in sortedArray)
            {
                Console.WriteLine(num);
            }
        }

        private static int[] SelectionSort(int[] array)
        {
            int i, j, min, temp;
            for (i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
            return array;
        }
    }
}