using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class DayTwo
{
    public static void StartDayTwo()
    {
        int saveCount = 0;
        string[] lines = System.IO.File.ReadAllLines("../../../Day02/Input.txt");

        foreach (string line in lines)
        {
            int[] numbers = Array.ConvertAll(line.Split(' '), int.Parse);

            if (IsRowValid(numbers))
            {
                saveCount++;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    var correctedNumbers = numbers.Where((_, index) => index != i).ToArray();

                    if (IsRowValid(correctedNumbers))
                    {
                        saveCount++;
                        break;
                    }
                }
            }
        }
        Console.WriteLine($"Number of save records: {saveCount}");
    }

    private static bool IsRowValid(int[] numbers)
    {
        return IsValidDifference(numbers) && (IsSorted(numbers, true) || IsSorted(numbers, false));
    }

    private static bool IsValidDifference(int[] row)
    {
        for (int i = 0; i < row.Length - 1; i++)
        {
            int difference = row[i] - row[i + 1];
            if (row[i] == row[i + 1] || Math.Abs(difference) >= 4)
            {
                return false;
            }
        }
        return true;
    }

    private static bool IsSorted(int[] row, bool ascending)
    {
        for (int i = 0; i < row.Length - 1; i++)
        {
            if (ascending && row[i] > row[i + 1] || !ascending && row[i] < row[i + 1])
            {
                return false;
            }
        }
        return true;
    }

}