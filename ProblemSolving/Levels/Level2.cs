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