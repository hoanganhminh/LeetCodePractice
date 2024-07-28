public class Solution
{
    public bool IsPalindrome(int x)
    {
        char[] list = x.ToString().ToCharArray();

        //if (!String.Join("", list.Reverse().ToArray()).Equals(String.Join("", list)))
        //{
        //    return false;
        //}

        return String.Join("", list.Reverse().ToArray()).Equals(String.Join("", list));
    }

    public int RomanToInt(string s)
    {
        int result = 0;
        char[] list = (s+"P").ToCharArray();

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == 'M') result += 1000;
            else if (list[i] == 'D') result += 500;
            else if (list[i] == 'C')
            {
                if (list[i+1] == 'D')
                {
                    result += 400;
                    i++;
                }
                else if (list[i+1] == 'M')
                {
                    result += 900;
                    i++;
                }
                else
                {
                    result += 100;
                }
            }
            else if (list[i] == 'L') result += 50;
            else if (list[i] == 'X')
            {
                if (list[i+1] == 'L')
                {
                    result += 40;
                    i++;
                }
                else if (list[i+1] == 'C')
                {
                    result += 90;
                    i++;
                }
                else
                {
                    result += 10;
                }
            }
            else if (list[i] == 'V') result += 5;
            else if (list[i] == 'I')
            {
                if (list[i+1] == 'V')
                {
                    result += 4;
                    i++;
                }
                else if (list[i+1] == 'X')
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

    public string LongestCommonPrefix(string[] strs)
    {
        return null;
    }
}