namespace TestConsoleApp.Problems.Easy.Add_Binary;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        while (a.Length != b.Length)
        {
            if (a.Length > b.Length)
            {
                b = '0' + b;
            }
            else if (b.Length > a.Length)
            {
                a = "0" + a;
            }
        }

        var flag = false;
        char[] bin1 = a.ToCharArray();
        char[] bin2 = b.ToCharArray();
        Stack<char> stack = new Stack<char>();
        int binSize = bin1.Length;

        for (int i = 0; i < binSize; i++)
        {
            if (flag)
            {
                if (bin1[binSize - i - 1] == '1')
                {
                    bin1[binSize - i - 1] = '0';
                }
                else
                {
                    bin1[binSize - i - 1] = '1';
                    flag = false;
                }
            }
            if (bin1[binSize - i - 1] != bin2[binSize - i - 1])
            {
                stack.Push('1');
            }
            else
            {
                if (bin1[binSize - i - 1] == '0')
                {
                    stack.Push('0');
                }
                else
                {
                    stack.Push('0');
                    flag = true;
                }
            }
            if (i == binSize - 1 && flag)
            {
                stack.Push('1');
            }
        }

        string result = "";

        while (stack.Count != 0)
        {
            result += stack.Pop();
        }

        return result;
    }
}