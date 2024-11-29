namespace LeetCodeSolutionsProject.Problems.Easy.Duplicate_Zeros;

public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        var length = arr.Length;
        var arrList = arr.ToList();
        var count = 0;

        for (int i = 0; i < length; i++)
        {
            if (arr[i] == 0)
            {
                arrList.Insert(i + count, 0);
                count++;
            }
        }

        for (int i = 0; i < length; i++)
        {
            arr[i] = arrList[i];
        }
    }
}
