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
            if (arr[i] >= secondMax && arr[i] != max)
            {
                secondMax = arr[i];
            }
        }
        Console.WriteLine(secondMax);
    }
    public static void CapitalizeFirstLetter(string word)
    {
        string newWord = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (i == 0)
            {
                newWord += word[i].ToString().ToUpper();
            }
            else
            {
                newWord += word[i];
            }
        }
        Console.WriteLine(newWord);
    }

    public static void CheckIfSorted(int[] arr)
    {
        int n = 0;
        int counter = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[n])
            {
                counter++;
                Console.WriteLine("false");
                break;
            }
            n++;
        }

        if (counter == 0)
        {
            Console.WriteLine("true");
        }
    }
}
