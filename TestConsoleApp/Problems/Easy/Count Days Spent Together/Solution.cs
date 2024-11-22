namespace TestConsoleApp.Problems.Easy.Count_Days_Spent_Together;

public class Solution
{
    public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
    {
        var arriveAliceDate = DateTime.Parse($"2023-{arriveAlice}");
        var leaveAliceDate = DateTime.Parse($"2023-{leaveAlice}");
        var arriveBobDate = DateTime.Parse($"2023-{arriveBob}");
        var leaveBobDate = DateTime.Parse($"2023-{leaveBob}");

        if (leaveAliceDate < arriveBobDate || leaveBobDate < arriveAliceDate)
        {
            return 0;
        }

        var minArrive = arriveAliceDate >= arriveBobDate ? arriveAliceDate : arriveBobDate;
        var minLeave = leaveAliceDate <= leaveBobDate ? leaveAliceDate : leaveBobDate;

        return (minLeave - minArrive).Days + 1;
    }
}