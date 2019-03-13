using System;
using System.Collections.Generic;

public static class Pangram
{

    public static bool IsPangram(string input)
    {
        bool result = false;
        int usedLetters = 0;

        IDictionary<int, bool> letterDictionary =
            new Dictionary<int, bool>();

        for (int i=97; i<=122; i++)
        {
            letterDictionary.Add(i, false);
        }

        foreach(char c in input.ToLower())
        {
            int charCode = (int)c;
            if(charCode >= 97 && charCode <= 122)
            {
                letterDictionary[charCode] = true;
            }
        }

        foreach(bool b in letterDictionary.Values)
        {
            if (b == true) usedLetters++;
        }

        if (usedLetters == 26) result = true;

        return result;
    }
}
