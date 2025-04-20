namespace ProblemSolving.Levels;

public class Level3
{
    public static void FindTheMissingNumber(int[] arr)
    {
        SortIntArray(arr);
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

    public static void FirstNonRepeatingCharacter(string word)
    {
        int counter = 0;
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (word[i] == word[j])
                {
                    counter = 1;
                    break;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine(i);
                break;           
            }

            counter = 0;
        }
    }
    public static void MergeTwoSortedArrays(int[] arr1, int[] arr2)
    {
        int[] newArr = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            newArr[i] = arr1[i];
        }
        
        for (int i = newArr.Length - 1; i >= 0; i--)
        {
            newArr[i] = arr2[i];
        }
        
        SortIntArray(newArr);
        PrintArray(newArr);
    }

    public static void IsAnagram(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            Console.WriteLine("false");
            return;
        }
        word1 = SortStringArray(word1.ToArray());
        word2 = SortStringArray(word2.ToArray());

        if (word1 == word2)
        {
            Console.WriteLine("true");
            return;
        }
        else
        {
            Console.WriteLine("false");     
            return;       
        }
    }
    
    private static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);       
        }
    }
    private static void SortIntArray(int[] arr)
    {
        Array.Sort(arr);
    }
    private static string SortStringArray(char[] arr)
    {
        Array.Sort(arr);
        return new string(arr);
    }
}