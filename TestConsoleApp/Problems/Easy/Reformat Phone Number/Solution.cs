namespace LeetCodeSolutionsProject.Problems.Easy.Reformat_Phone_Number;

public class Solution
{
    public string ReformatNumber(string number)
    {
        var formatedNumber = "";
        var count = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == ' ' || number[i] == '-')
            {
                continue;
            }

            if (count == 3)
            {
                formatedNumber += "-";
                count = 0;
            }

            formatedNumber += number[i];
            count++;
        }

        if (formatedNumber[formatedNumber.Length - 2] == '-')
        {
            var reFormated = "-" + formatedNumber[formatedNumber.Length - 3] + formatedNumber[formatedNumber.Length - 1];
            formatedNumber = formatedNumber.Remove(formatedNumber.Length - 3) + reFormated;
        }

        return formatedNumber;
    }
}