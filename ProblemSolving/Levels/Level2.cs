namespace ProblemSolving;

public class Level2
{
    private static readonly char[] _vowels = {'a', 'e', 'i', 'o', 'u'};

    public static void CountVowels(string word)
    {
        int counter = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (IsExist(word[i]))
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
    public static void IsVowel(char letter)
    {
        Console.WriteLine(IsExist(letter));
    }
    public static void ReverseString(string word)
    {
        for (int i = word.Length - 1; i >= 0; i--)
        {
            Console.Write(word[i]);
        }
    }
    public static void IsPalindrome(string word)
    {
        if (word.Length >= 1)
        {
            Console.WriteLine(ReverseWord(word) == word);
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    public static void IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    private static string ReverseWord(string word)
    {
        string newWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            newWord += word[i];
        }

        return newWord;
    }
    private static bool IsExist(char letter)
    {
        
        for (int i = 0; i < _vowels.Length; i++)
        {
            if (letter == _vowels[i])
            {
                return true;
            }
        }
        return false;
    }
}