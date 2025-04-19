using ProblemSolving.Shared;

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
    public static bool IsLeapYearOneLine(int year)
    {
        return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
    }
    public static void DateInWords(int day, int month, int year)
    {
        Console.WriteLine($"Today is : {day}/{month}/{year}");
    }
    public static void CompareDates(Date date1, Date date2)
    {
        if (date1.Year == date2.Year)
        {
            if (date1.Month == date2.Month)
            {
                if (date1.Day == date2.Day)
                    Console.WriteLine("Equal");
                else if (date1.Day > date2.Day)
                    Console.WriteLine("Date 1 is Greater");
                else
                    Console.WriteLine("Date 2 is Greater");
            }
            else if (date1.Month > date2.Month)
                Console.WriteLine("Date 1 is Greater");
            else
                Console.WriteLine("Date 2 is Greater");
        }
        else if (date1.Year > date2.Year)
            Console.WriteLine("Date 1 is Greater");
        else
            Console.WriteLine("Date 2 is Greater");
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