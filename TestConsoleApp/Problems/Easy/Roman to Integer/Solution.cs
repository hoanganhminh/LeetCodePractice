namespace LeetCodeSolutionsProject.Problems.Easy.Roman_to_Integer;

public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;
        char[] list = s.ToCharArray();

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == 'M')
                result += 1000;

            else if (list[i] == 'D')
                result += 500;

            else if (list[i] == 'C')
            {
                if ((i + 1) < list.Length && list[i + 1] == 'D')
                {
                    result += 400;
                    i++;
                }
                else if ((i + 1) < list.Length && list[i + 1] == 'M')
                {
                    result += 900;
                    i++;
                }
                else
                {
                    result += 100;
                }
            }

            else if (list[i] == 'L')
                result += 50;

            else if (list[i] == 'X')
            {
                if ((i + 1) < list.Length && list[i + 1] == 'L')
                {
                    result += 40;
                    i++;
                }
                else if ((i + 1) < list.Length && list[i + 1] == 'C')
                {
                    result += 90;
                    i++;
                }
                else
                {
                    result += 10;
                }
            }

            else if (list[i] == 'V')
                result += 5;

            else if (list[i] == 'I')
            {
                if ((i + 1) < list.Length && list[i + 1] == 'V')
                {
                    result += 4;
                    i++;
                }
                else if ((i + 1) < list.Length && list[i + 1] == 'X')
                {
                    result += 9;
                    i++;
                }
                else
                {
                    result += 1;
                }
            }
        }

        return result;
    }
}
