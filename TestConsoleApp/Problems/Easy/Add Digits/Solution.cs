namespace TestConsoleApp.Problems.Easy.Add_Digits;

public class Solution
{
    public int AddDigits(int num)
    {
        while (num > 9)
        {
            var num2 = 0;

            foreach (var item in num.ToString().ToCharArray())
            {
                num2 += item - '0';
            };

            num = num2;
        }

        return num;
    }
}