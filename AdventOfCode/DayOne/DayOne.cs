using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

class DayOne
{
    public static void StartDayOne()
    {
        List<int> inputOne = new List<int>();
        List<int> inputTwo = new List<int>();
        string[] lines = System.IO.File.ReadAllLines("..\\..\\..\\DayOne\\Input.txt");

        foreach (string line in lines)
        {
            string[] sNumbers = Regex.Replace(line, @"\s+", " ").Split(' ');
            inputOne.Add(Convert.ToInt32(sNumbers[0]));
            inputTwo.Add(Convert.ToInt32(sNumbers[1]));
        }

        Console.WriteLine(PartOne(inputOne, inputTwo));
        Console.WriteLine(PartTwo(inputOne, inputTwo));
    }

    private static int PartOne(List<int> inputOne, List<int> inputTwo)
    {
        int result = 0;

        inputOne.Sort();
        inputTwo.Sort();

        for (int i = 0; i < inputOne.Count; i++)
        {
            result += Math.Abs(inputOne[i] - inputTwo[i]);
        }
        
        return result;
    }

    private static int PartTwo(List<int> inputOne, List<int> inputTwo)
    {
        int result = 0;

        foreach (int i in inputOne)
        {
            result += inputTwo.Count(x => x == i) * i;
        }
        return result;
    }
}