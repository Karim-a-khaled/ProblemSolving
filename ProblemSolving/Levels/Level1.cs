namespace ProblemSolving.Levels;

public class Level1
{
    public static void InvertedNumberASC(int number)
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
    
    public static void InvertedLetterASC(int number)
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
    
    public static void InvertedLetterDEC(int number)
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
}