using System;
using System.Linq;

public static class Isogram
{
 
    public static bool IsIsogram(string word)
    {

        var temp = word.ToLower().Where(c => Char.IsLetter(c));
        return temp.Distinct().Count() == temp.Count();
    }
}
