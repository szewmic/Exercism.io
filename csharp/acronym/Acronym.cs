using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        return String.Concat(phrase.ToUpper().Split(new char[] {'-',' ' }).Where(s => !String.IsNullOrEmpty(s)).Select(s => s[0]));
    }
}