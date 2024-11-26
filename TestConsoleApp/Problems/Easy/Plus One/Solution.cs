using System.Numerics;

namespace LeetCodeSolutionsProject.Problems.Easy.Plus_One;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        BigInteger num = 0;

        foreach (int i in digits)
        {
            num = (num + i) * 10;
        }

        num = num / 10 + 1;
        char[] chars = num.ToString().ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (i < digits.Length)
            {
                digits[i] = int.Parse(chars[i].ToString());
            }
            else
            {
                return digits.Append(int.Parse(chars[i].ToString())).ToArray();
            }
        }

        return digits;
    }
}