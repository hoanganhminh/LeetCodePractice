namespace TestConsoleApp.Problems.Easy.Valid_Parentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        try
        {
            var list = s.ToCharArray();

            if (list.Length <= 1) return false;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == '(' && list[i + 1] != ')' && list[list.Length - 1 - i] != ')') return false;
                if (list[i] == '{' && list[i + 1] != '}' && list[list.Length - 1 - i] != '}') return false;
                if (list[i] == '[' && list[i + 1] != ']' && list[list.Length - 1 - i] != ']') return false;
                if (list[i] == ')' && list[i + 1] != '(' && list[list.Length - 1 - i] != '(') return false;
                if (list[i] == '}' && list[i + 1] != '{' && list[list.Length - 1 - i] != '{') return false;
                if (list[i] == ']' && list[i + 1] != '[' && list[list.Length - 1 - i] != '[') return false;
            }

            return true;
        }
        catch
        {
            return false;
        }
    }
}
