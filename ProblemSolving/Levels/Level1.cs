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
}