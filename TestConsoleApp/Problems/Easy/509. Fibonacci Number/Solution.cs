namespace LeetCodeSolutionsProject.Problems.Easy._509._Fibonacci_Number;

public class Solution
{
    Dictionary<int, int> dic = [];

    public int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        if (dic.TryGetValue(n, out int val))
        {
            return val;
        }

        var rs = Fib(n - 1) + Fib(n - 2);
        dic.Add(n, rs);

        return rs;
    }
}