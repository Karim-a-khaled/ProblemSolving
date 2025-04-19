﻿using ProblemSolving.Levels;
using ProblemSolving.Shared;

namespace ProblemSolving;

class Program
{
    static void Main(string[] args)
    {
        #region Level One Problems
            // Level1.InvertedNumberAsc(4);
            // Level1.InvertedLetterAsc(4);
            // Level1.InvertedLetterDec(4);
            // Level1.Encrypt("mohammad", 2);
            // Level1.Dcrypt("OQJCOOCF", 2, '-');
            // Level1.RandomNumber(1, 30, 3);
            // Level1.GenerateKeys();
            // Level1.RepeatedNumber(1113,1);
            // int[] array = new int[10];
            // Level1.FillingArray(array);
            // Level1.PrintArray(array);
            // Level1.SumArray([1,2,3,4]); // this was changed from void into returning an int
            // Level1.AverageArray([1,2,3,4,5]);
            // Level1.EvenNumbers([1,2,3,4,5,6]);
            // Level1.OddNumbers([1,2,3,4,5,6]);
        #endregion
        
        #region Level Two Problems

            // Level2.IsVowel('a');
            // Level2.IsVowel('k');
            // Level2.CountVowels("hello");
            // Level2.ReverseString("kairm");
            // Level2.IsPalindrome("");
            // Level2.IsLeapYear(1968);
            // Level2.IsLeapYearOneLine(1968);
            // Level2.DateInWords(1, 1, 2022);
            Date date1 = new Date(1,1,2022);
            Date date2 = new Date(1,1,2000);
            Level2.CompareDates(date1, date2);


            #endregion
    }
}