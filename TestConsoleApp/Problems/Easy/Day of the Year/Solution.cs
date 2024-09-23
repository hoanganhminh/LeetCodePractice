namespace TestConsoleApp.Problems.Easy.Day_of_the_Year;

public class Solution
{
    public int DayOfYear(string date)
    {
        return DateTime.Parse(date).DayOfYear;
    }
}
