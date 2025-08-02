namespace LeetCodeSolutionsProject.Problems.Easy._1576._Replace_All_question_s_to_Avoid_Consecutive_Repeating_Characters;

public class Solution
{
    public string ModifyString(string s)
    {
        var list = new List<char>()
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z',
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z',
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z',
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z'
        };
        var rs = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '?')
            {
                list.Remove(s[i]);
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '?')
            {
                rs += list[0];
                list.RemoveAt(0);
            }
            else
            {
                rs += s[i];
            }
        }

        return rs;
    }
}