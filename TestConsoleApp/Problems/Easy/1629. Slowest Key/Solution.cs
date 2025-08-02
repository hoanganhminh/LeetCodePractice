namespace LeetCodeSolutionsProject.Problems.Easy._1629._Slowest_Key;

public class Solution
{
    public char SlowestKey(int[] releaseTimes, string keysPressed)
    {
        var currentLongestDuration = releaseTimes[0];
        var currentLatgestDurationIndex = 0;

        for (var i = 1; i < releaseTimes.Length; i++)
        {
            var currentDuration = releaseTimes[i] - releaseTimes[i - 1];
            if (currentLongestDuration < currentDuration)
            {
                currentLatgestDurationIndex = i;
                currentLongestDuration = currentDuration;
            }
            else if (currentLongestDuration == currentDuration)
            {
                currentLatgestDurationIndex = keysPressed[i] - keysPressed[currentLatgestDurationIndex] > 0 ? i : currentLatgestDurationIndex;
            }
        }

        return keysPressed[currentLatgestDurationIndex];
    }
}