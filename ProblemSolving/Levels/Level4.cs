using System.Collections.Specialized;
using ProblemSolving.Shared;

namespace ProblemSolving.Levels;

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
    public static void MaximumConsecutiveOnes(int[] arr)
    {
        int counter = 0;
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                counter++;
                if (max < counter)
                {
                    max = counter;
                }
            }
            else
            {
                counter = 0;
            }
        }
        Console.WriteLine(max);
    }
    public static void RemoveDuplicates(int[] arr)
    {
        List<int> newArr = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int counter = 0;

            for (int j = 0; j < newArr.Count; j++)
            {
                if (arr[i] == newArr[j])
                {
                    counter++;
                    break;
                }
            }

            if (counter == 0)
            {
                newArr.Add(arr[i]);
            }
        }
        
        ArrayFunctions.PrintArray(newArr.ToArray());
    }

    public static void ContainsDuplicates(int[] arr)
    {
        Array.Sort(arr);
        int counter = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if(arr[counter] == arr[i])
            {
                Console.WriteLine("true");
                break;
            }
            counter++;
        }
        Console.WriteLine("false");
    }
}
