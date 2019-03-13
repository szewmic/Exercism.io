using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> nucleotideCount =
            new Dictionary<char, int>() { { 'A', 0 }, { 'C', 0 }, { 'T', 0 }, { 'G', 0 } };

        foreach (char c in sequence)
        {
            if (!nucleotideCount.Keys.Contains(c))
                throw new ArgumentException();
            else
                nucleotideCount[c] += 1;
        }
        

        return nucleotideCount;
    }
}