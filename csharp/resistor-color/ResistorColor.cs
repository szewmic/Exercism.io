using System;
using System.Linq;

public static class ResistorColor
{
    private static readonly string[] colors = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color)
    {
        return Array.IndexOf(colors, color);
    }

    public static string[] Colors()
    {
        return colors;
    }
}