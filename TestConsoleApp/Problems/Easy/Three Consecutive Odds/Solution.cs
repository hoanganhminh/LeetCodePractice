namespace TestConsoleApp.Problems.Easy.Three_Consecutive_Odds;

public class Solution
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if(i >= arr.Length - 1 - 1)
                return false;

            if (arr[i] % 2 != 0 && arr[i + 1] % 2 != 0 && arr[i + 2] % 2 != 0)
                return true;
        }

        return false;
    }
}