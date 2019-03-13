using System;

public static class Raindrops
{
    private const string FACTOR_THREE_SOUND = "Pling";
    private const string FACTOR_FIVE_SOUND = "Plang";
    private const string FACTOR_SEVEN_SOUND = "Plong";

    public static string Convert(int number)
    {
        string rainDropSpeak = "";

        if (number % 3 == 0)
            rainDropSpeak = rainDropSpeak + FACTOR_THREE_SOUND;
        if (number % 5 == 0)
            rainDropSpeak = rainDropSpeak + FACTOR_FIVE_SOUND;
        if (number % 7 == 0)
            rainDropSpeak = rainDropSpeak + FACTOR_SEVEN_SOUND;

        if (rainDropSpeak.Length == 0)
            return number.ToString();
        else
            return rainDropSpeak;
    }
}