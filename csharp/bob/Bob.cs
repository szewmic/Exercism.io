using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        int  allLetters = statement.Where(w => Char.IsLetter(w)).Count(); 

        return (allLetters == 0 && string.IsNullOrWhiteSpace(statement)) || statement == null
            ? "Fine. Be that way!"
            : allLetters == statement.Where(w => Char.IsUpper(w)).Count() && allLetters > 0
                ? statement.Last() == '?' ? "Calm down, I know what I'm doing!" : "Whoa, chill out!"
                : statement.TrimEnd().Last() == '?' ? "Sure." : "Whatever.";
    }
}