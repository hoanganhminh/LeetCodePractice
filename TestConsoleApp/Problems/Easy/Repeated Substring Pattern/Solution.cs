namespace LeetCodeSolutionsProject.Problems.Easy.Repeated_Substring_Pattern;

public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        List<int> divisors = [];
        var sLength = s.Length;

        if (sLength == 1)
        {
            return false;
        }

        for (int i = 1; i <= Math.Sqrt(sLength); i++)
        {
            if (sLength % i == 0)
            {
                divisors.Add(i);

                if (i != sLength / i && sLength != sLength / i)
                {
                    divisors.Add(sLength / i);
                }
            }
        }

        foreach (int i in divisors)
        {
            var n = sLength / i;
            var hsString = new HashSet<string>();

            for (int j = 0; j < n; j++)
            {
                var part = s.Substring(j * (sLength / n), sLength / n);
                hsString.Add(part);

                if (hsString.Count > 1)
                {
                    break;
                }
            }

            if (hsString.Count == 1)
            {
                return true;
            }
        }

        return false;
    }
}