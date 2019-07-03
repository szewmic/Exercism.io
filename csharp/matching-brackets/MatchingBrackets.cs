using System;
using System.Collections.Generic;
using System.Linq;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        var onlyBrackets = new string(input.Select(s => s).Where(ch => isBracket(ch)).ToArray());

        if (onlyBrackets.Count() % 2 != 0) return false;
        else
        {
            while (onlyBrackets.Count()>0)
            {
                if (GetComplementBracket(onlyBrackets[0]) == onlyBrackets[1])
                {
                    onlyBrackets = onlyBrackets.Substring(2);
                }
                else if (GetComplementBracket(onlyBrackets[0]) == onlyBrackets[onlyBrackets.Length - 1])
                    onlyBrackets = onlyBrackets.Substring(1, onlyBrackets.Count() - 2);
                else
                    return false;
            }
        }
        return true;
    }

    private static bool isBracket(char input)
    {
        List<char> options = new List<char>() { '(', ')', '{', '}', '[', ']' };
        return options.Contains(input);
    }

    private static char GetComplementBracket(char item)
    {
        switch (item)
        {
            case '(':
                return ')';
            case '{':
                return '}';
            case '[':
                return ']';
            default:
                return ' ';
        }
    }
}



