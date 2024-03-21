using System;

class Sorting
{
    public static void PrintArray<T>(T[] array)
    {
        foreach (var value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

    public static int GetMaxValue(int[] array)
    {
        int max = -9999999;

        foreach (var value in array)
        {
            if (value > max)
            {
                max = value;
            }
        }
        return max;
    }
    public static int[] CountingSort(int[] array)
    {
        int arrLen = array.Length;
        int maxVal = GetMaxValue(array);
        var countArray = new int[maxVal + 1];
        var sortedArray = new int[arrLen];

        foreach (var value in array)
        {
            countArray[value]++;
        }

        int index = 0;

        for (int i = 0; i <= maxVal; i++)
        {
            while (countArray[i] > 0)
            {
                sortedArray[index] = i;
                index++;
                countArray[i]--;
            }
        }

        return sortedArray;
    }

    public static int[] RadixSort(int[] array)
    {
        int arrLen = array.Length;
        int maxVal = GetMaxValue(array);

        for (int num = 1; maxVal / num > 0; num *= 10)
        {
            var countArray = new int[10];

            for (int i = 0; i < arrLen; i++)
            {
                int digit = (array[i] / num) % 10;
                countArray[digit]++;
            }

            int index = 0;

            for (int i = 0; i < 10; i++)
            {
                while (countArray[i] > 0)
                {
                    array[index] = i * num;
                    index++;
                    countArray[i]--;
                }
            }
        }

        return array;
    }

    public static double[] InsertionSort(double[] array)
    {
        int arrLen = array.Length;

        for (int i = 1; i < arrLen; i++)
        {
            double key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }

        return array;
    }

    public static void Main(string[] args)
    {
        int[] arr1 = [1, 2, 1, 2, 2, 2, 2, 1, 2, 1, 2, 1, 1, 1, 1, 2, 2, 1];
        int[] arr2 = [513, 124, 240, 582, 230, 123, 251, 124, 213, 123, 215, 123, 215, 463, 385, 942, 813];
        double[] arr3 = [421.24, 1240.9, 1623, 539.3, 6230, 219, 21, 1, 17, 692];

        int[] sorted1 = CountingSort(arr1);
        int[] sorted2 = RadixSort(arr2);
        double[] sorted3 = InsertionSort(arr3);

        Console.Write("Counting Sort: ");
        PrintArray(sorted1);
        Console.Write("Radix Sort: ");
        PrintArray(sorted2);
        Console.Write("Insertion Sort: ");
        PrintArray(sorted3);

    }
}