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
    public static void SumUntilSingleDigit(int number)
    {
        int sum = 0;
        while (number > 9)
        {
            sum += number % 10;
            number /= 10;
        }
        number = sum;
        Console.WriteLine(number);
    }
    public static void FindTheSingleNumber(int[] arr)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j] && i != j)
                {
                    counter++;
                    break;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine(arr[i]);
                break;
            }
            counter = 0;       
        }
    }
    public static void FindTheSingleNumberUsingXor(int[] arr)
    {
        int result = 0;
        foreach (int num in arr)
        {
            result ^= num; 
        }
        Console.WriteLine(result);
    }
    public static void MoveZeros(int[] arr)
    {
        int counter = 0;
        int[] newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                newArr[counter] = arr[i];
                counter++;           
            }
        }

        for (int i = arr.Length - 1; i < newArr.Length; i++)
        {
            newArr[i] = 0;
        }
        
        PrintArray(newArr);
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