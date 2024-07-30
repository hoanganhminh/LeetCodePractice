namespace TestConsoleApp.Problems.Easy.Valid_Parentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        try
        {
            List<char> list = s.ToCharArray().ToList();

            if (list.Count <= 1 || list.Count % 2 != 0) return false;

            bool flag = true;

            while (flag)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    flag = false;

                    if (list[i] == ')' && list[i - 1] == '(')
                    {
                        list.RemoveAt(i);
                        list.RemoveAt(i - 1);
                        flag = true;
                        break;
                    }
                    if (list[i] == '}' && list[i - 1] == '{')
                    {
                        list.RemoveAt(i);
                        list.RemoveAt(i - 1);
                        flag = true;
                        break;
                    }
                    if (list[i] == ']' && list[i - 1] == '[')
                    {
                        list.RemoveAt(i);
                        list.RemoveAt(i - 1);
                        flag = true;
                        break;
                    }
                }

                if (list.Count == 0) return true;
            }

            return list.Count == 0 ? true : false;
        }
        catch (Exception)
        {
            return false;
        }
    }
}