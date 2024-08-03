namespace TestConsoleApp.Problems.Easy.Merge_Sorted_Array;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] tempNums1 = nums1.Take(m).Concat(nums2.Take(n)).Order().ToArray();

        for (int i = 0; i < m + n ; i++)
        {
            nums1[i] = tempNums1[i];
        }
    }
}
