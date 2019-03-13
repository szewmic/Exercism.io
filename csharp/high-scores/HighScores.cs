using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> highscores;
    public HighScores(List<int> list)
    {
        this.highscores = list;
    }

    public List<int> Scores()
    {
        return highscores;
    }

    public int Latest()
    {
        return highscores.Last();
    }

    public int PersonalBest()
    {
        return highscores.Max();
    }

    public List<int> PersonalTopThree()
    {
        return highscores.OrderByDescending(h => h).Take(3).ToList();
    }
}