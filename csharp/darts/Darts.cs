using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        int score = 0;
        var distFromCenter = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        if (distFromCenter <= 1)
            score = 10;
        else if (distFromCenter <= 5)
            score = 5;
        else if (distFromCenter <= 10)
            score = 1;

        return score;
    }
}
