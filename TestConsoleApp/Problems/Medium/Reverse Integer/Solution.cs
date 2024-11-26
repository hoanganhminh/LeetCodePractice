namespace LeetCodeSolutionsProject.Problems.Medium.Reverse_Integer;

public class Solution
{
    public int Reverse(int x)
    {
        int minor = 1;
        int rs = 0;

        if (x < 0)
        {
            minor = -1;
            x *= minor;
        }

        char[] rv = x.ToString().ToCharArray();
        Array.Reverse(rv);

        return Int32.TryParse(rv, out rs) ? rs * minor : rs;
    }
}