namespace LeetCodeSolutionsProject.Problems.Easy.Find_Winner_on_a_Tic_Tac_Toe_Game;

public class Solution
{
    public string Tictactoe(int[][] moves)
    {
        if (moves.Length < 5) return "Pending";

        var aMoves = new List<int[]>();
        var bMoves = new List<int[]>();

        for (int i = 0; i < moves.Length; i++)
        {
            if (i % 2 == 0)
            {
                aMoves.Add(moves.ElementAt(i));
            }
            else
            {
                bMoves.Add(moves.ElementAt(i));
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (aMoves.Select(x => x[i]).Count(x => x == j) == 3)
                {
                    return "A";
                }

                if (bMoves.Select(x => x[i]).Count(x => x == j) == 3)
                {
                    return "B";
                }
            }
        }

        if (aMoves.Count(x => x[0] == x[1]) == 3)
        {
            return "A";
        }

        if (bMoves.Count(x => x[0] == x[1]) == 3)
        {
            return "B";
        }

        if (aMoves.Count(x => x[0] + x[1] == 2) == 3)
        {
            return "A";
        }

        if (bMoves.Count(x => x[0] + x[1] == 2) == 3)
        {
            return "B";
        }

        return moves.Length == 9 ? "Draw" : "Pending";
    }
}