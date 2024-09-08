namespace TestConsoleApp.Problems.Easy.Happy_Number;

public class Solution
{
    public bool IsHappy(int n)
    {
        int val = 0;

        while (n - 10 >= 0)
        {
            foreach (char a in n.ToString().ToCharArray())
            {
                val += (int)Math.Pow(int.Parse(a.ToString()), 2);
            }

            n = val;
            val = 0;
        }

        return n == 1 || n == 7 ? true : false;
    }
}