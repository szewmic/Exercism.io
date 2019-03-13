using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if (Validation(digits, span))
        {
            return Enumerable.Range(0, digits.Length - span + 1)
                        .Select(s => digits.Substring(s, span))
                        .Select(s =>
                        {
                            int multipiedInSpan = 1;

                            foreach (char c in s)
                            {
                                multipiedInSpan *= (int)char.GetNumericValue(c);
                            }

                            return multipiedInSpan;
                        })
                        .Max();
        }
        return 1;              
    }

    private static bool Validation(string digits, int span)
    {
        if (span > digits.Length || digits == null || digits.Any(d=>!char.IsDigit(d)) || span <0)
            throw new ArgumentException();
        return true;
    }
}