using System;
using System.Linq;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string temp = "";

        if (startBottles > 2)
        temp = Enumerable.Range(3, startBottles-2).Reverse().Take(takeDown)
             .Select(s => $"{s} bottles of beer on the wall, {s} bottles of beer.\nTake one down and pass it around, {s - 1} bottles of beer on the wall.")
             .Aggregate((a, b) => a + "\n\n" + b);

        temp = temp + GetUniqueParts(takeDown - startBottles - 2);

        return temp;
    }

    private static string GetUniqueParts(int startBottles)
    {
        string uniquePart = "";

        string twoBottlesVerse = "\n2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n";

        string oneBottleVerse = "\n1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n";

        string noMoreVerses = "\nNo more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";


        return uniquePart;
    }
}