using System;

class Sorting
{

    public static int GetMaxValue(int[] arr)
    {
        int max = -9999999;

        foreach (var value in arr)
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
        int[] countArray = new int[maxVal + 1];
        int[] sortedArray = new int[arrLen];

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

    public static void Main(string[] args)
    {
        int[] arr1 = [1, 2, 1, 2, 2, 2, 2, 1, 2, 1, 2, 1, 1, 1, 1, 2, 2, 1];
        int[] arr2 = [513, 124, 240, 582, 230, 123, 251, 124, 213, 123, 215, 123, 215, 463, 385, 942, 813];
        float[] arr3 = [421.24, 1240.9, 1623, 539.3, 6230, 219, 21, 1, 17, 692];

        int[] sorted1 = CountingSort(arr1);

        foreach (var value in sorted)
        {
            Console.Write(value + " ");
        }
    }
}