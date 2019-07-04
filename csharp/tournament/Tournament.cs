using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class Tournament
{   
    public static void Tally(Stream inStream, Stream outStream)
    {
        League league = new League();
        Split(inStream, league);

        using (var sw = new StreamWriter(outStream))
        {
            sw.Write(CreateFile(league.Teams));
        }

    }
    private static void Split(Stream inStream, League league)
    {
        StreamReader reader = new StreamReader(inStream);
        string inString = reader.ReadToEnd();

        var fileLines = inString.Split('\n', StringSplitOptions.None);

        foreach (string matchLine in fileLines)
        {
            if(!string.IsNullOrEmpty(matchLine))
             league.PopulateMatchResult(new Match(matchLine));
        }
    }
    private static string CreateFile(List<Team> teams)
    {
        var header = "Team                           | MP |  W |  D |  L |  P";
        var content = header;

        var sortedTeams = teams.OrderByDescending(x => x.getPoints()).ThenBy(x=>x.Name);

        foreach(Team team in sortedTeams)
        {
            content += "\n"+  team.Name;
            for (int i=0; i<31-team.Name.Length; i++)
            {
                content += " ";
            }
            content += $"|  {team.getMatchesPlayed()} ";
            content += $"|  {team.Wins} ";
            content += $"|  {team.Draws} ";
            content += $"|  {team.Losses} ";
            content += $"|  {team.getPoints()}";
        }
        return content;
    }
}

public class League
{
    public List<Team> Teams = new List<Team>();

    public void PopulateMatchResult(Match match)
    {
        if (!Teams.Any(x => x.Name == match.HomeTeam.Name))
            Teams.Add(match.HomeTeam);
        if (!Teams.Any(x => x.Name == match.AwayTeam.Name))
            Teams.Add(match.AwayTeam);

        AssignResult(match.Result, Teams.Find(x => x.Name == match.HomeTeam.Name), Teams.Find(x => x.Name == match.AwayTeam.Name));
    }
    private void AssignResult(string result, Team homeTeam, Team awayTeam)
    {
        switch (result)
        {
            case "draw":
                homeTeam.Draws++;
                awayTeam.Draws++;
                break;
            case "loss":
                homeTeam.Losses++;
                awayTeam.Wins++;
                break;
            case "win":
                homeTeam.Wins++;
                awayTeam.Losses++;
                break;
            default:
                break;
        }
    }
}
public class Match
{
    public Team HomeTeam { get; set; }
    public Team AwayTeam { get; set; }
    public string Result { get; set; }

    public Match(string matchLine)
    {
        var splitted = matchLine.Split(';', StringSplitOptions.None);

        this.HomeTeam = new Team(splitted[0]);
        this.AwayTeam = new Team( splitted[1]);
        this.Result = splitted[2];

    }
}
public class Team
{
    public string Name { get; set; }
    public int Wins { get; set; }
    public int Draws { get; set; }
    public int Losses { get; set; }

    public Team(string name)
    {
        this.Name = name;
        Wins = 0;
        Draws = 0;
        Losses = 0;
    }

    public int getMatchesPlayed() => Wins + Draws + Losses;
    public int getPoints() => 3 * Wins + 1 * Draws;
}
