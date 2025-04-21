using ProblemSolving.Shared;

namespace ProblemSolving;

public class Level4
{
    public static void SecondLargestNumber(int[] arr)
    {
        int max = ArrayFunctions.FindMax(arr);
        int secondMax = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > secondMax && arr[i] != max)
            {
                secondMax = arr[i];
            }
        }
        Console.WriteLine(secondMax);
    }
}