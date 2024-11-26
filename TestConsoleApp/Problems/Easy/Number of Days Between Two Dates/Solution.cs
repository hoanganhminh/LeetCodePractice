namespace LeetCodeSolutionsProject.Problems.Easy.Number_of_Days_Between_Two_Dates;

public class Solution
{
    public int DaysBetweenDates(string date1, string date2)
    {
        var from = DateTime.Parse(date1);
        var to = DateTime.Parse(date2);

        return (int)Math.Abs((from - to).TotalDays);
    }
}