namespace ProblemSolving.Levels;

public class Level1
{
    private static Random random = new Random();
    public static void InvertedNumberAsc(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
    public static void InvertedLetterAsc(int number)
    {
        char[] letters = { 
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 
            'V', 'W', 'X', 'Y', 'Z' 
        };    
        
        for (int i = 0; i <= number; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(letters[i]);
            }
            Console.WriteLine();
        }
    }
    public static void InvertedLetterDec(int number)
    {
        char[] letters = { 
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 
            'V', 'W', 'X', 'Y', 'Z' 
        };    
        
        for (int i = number; i >= 0; i--)
        {
            for (int j = 0; j <= number; j++)
            {
                Console.Write(letters[i]);
            }
            Console.WriteLine();
            number--;
        }
    }
    public static void Encrypt(string text, int key)
    {
        string newText = "";

        for (int i = 0; i < text.Length; i++)
        {
            int asciiValue = (int)text[i] + key;
            newText += (char)asciiValue;
        }
            
        Console.WriteLine(newText.ToUpper());
    }    
    public static void Dcrypt(string text, int key, char operation)
    {
        if (operation != '+' && operation != '-')
        {
            throw new ArgumentException("Invalid operation");
        }
        text = text.ToLower();
        Console.WriteLine(text);
        
        string newText = "";

        for (int i = 0; i < text.Length; i++)
        {
            int asciiValue = 0;
            if (operation == '+')
            {
                asciiValue = (int)text[i] + key;
            }
            else
            {
                asciiValue = (int)text[i] - key;
            }
            newText += (char)asciiValue;
        }
            
        Console.WriteLine(newText.ToUpper());
    }
    public static void RandomNumber(int from, int to, int numberOfRandomNumbers)
    {
        int randomNumber = 0;
        
        for (int i = 0; i < numberOfRandomNumbers; i++)
        {
            randomNumber = GenerateRandomNumber();
            Console.WriteLine(randomNumber);
        }
    }
    public static void GenerateKeys()
    {
        string key = "";

        for (int i = 0; i < 4; i++)
        {
            key += GenerateKey();
            if (i < 3) key += "-";
        }
        
        Console.WriteLine(key);
    }
    public static void RepeatedNumber(int number, int searchedNumber)
    {
        string numbers = number.ToString();
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (int.TryParse(numbers[i].ToString(), out int digit))
            {
                if (digit == searchedNumber)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
    public static void FillingArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = GenerateRandomNumber();
        }
    }
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    
    private static int GenerateRandomNumber()
    {
        return random.Next();
    }
    private static string GenerateKey()
    {
        string text = "";

        for (int i = 0; i < 4; i++)
        {
            text += (char)random.Next(65, 91);
        }
        
        return text;
    }
 
}