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
        int result = 0;
        string[] lines = System.IO.File.ReadAllLines("..\\..\\..\\DayTwo\\Input.txt");

        foreach(string line in lines)
        {
            List<int> numbers = new List<int>();
            string[] sNumbers = line.Split(' ');

            foreach(string number in sNumbers)
            {
                numbers.Add(Convert.ToInt32(number));   
            }
        }
    }
}