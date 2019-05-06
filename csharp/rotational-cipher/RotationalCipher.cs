using System;
using System.Linq;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        return String.Concat(text.Select(s=> s.ShiftLetters(shiftKey)));
    }

    public static char ShiftLetters(this char c, int shift)
    {
        if (char.IsLetter(c))
        {
            int minChar = 96;
            int maxChar = 122;

            if (Char.IsUpper(c))
            {
                maxChar -= 32;
                minChar -= 32;
            }

            var outputChar = c + shift;

            if (outputChar > maxChar)
            {
                outputChar = minChar + (outputChar - maxChar);
            }

            return (char)outputChar;
        }
        else
            return c;
    }
}