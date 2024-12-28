using System;
using System.Text.RegularExpressions;

class DayThree
{
    public static void StartDayThree()
    {
        string input = System.IO.File.ReadAllText("../../../Day03/input.txt");
        int result = 0;
        bool enable = true;

        string pattern = @"mul\((\d{1,3}),(\d{1,3})\)|(do\(\))|(don't\(\))";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            if (match.Groups[4].Success)
            {
                enable = false;
            }
            else if (match.Groups[3].Success)
            {
                enable = true;
            }
            else if (match.Groups[1].Success && match.Groups[2].Success && enable) // mul(x, y)
            {
                int number1 = int.Parse(match.Groups[1].Value);
                int number2 = int.Parse(match.Groups[2].Value);
                result += number1 * number2;
            }
        }
        Console.WriteLine($"Result of Mul(x,y): {result}");
    }
}