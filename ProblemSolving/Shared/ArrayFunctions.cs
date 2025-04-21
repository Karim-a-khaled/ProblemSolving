namespace ProblemSolving.Shared;

public class ArrayFunctions
{
    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);       
        }
    }
    public static void SortIntArray(int[] arr)
    {
        Array.Sort(arr);
    }
    public static string SortStringArray(char[] arr)
    {
        Array.Sort(arr);
        return new string(arr);
    }
    public static int FindMax(int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    public static int FindMin(int[] arr)
    {
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }

    public static void FillArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = 0;
        }
    }
}