namespace ProblemSolving.Levels;

public class Level3
{
    public static void FindTheMissingNumber(int[] arr)
    {
        SortArray(arr);
        int counter = 0;
        int number = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != number)
            {
                Console.WriteLine(number);
                counter = 1;
                break;
            }
            number++;
        }

        if (counter == 0)
        {
            Console.WriteLine(-1);
        }
    }

    private static void SortArray(int[] arr)
    {
        Array.Sort(arr);
    }
}