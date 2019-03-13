using System;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length || sliceLength <= 0 || numbers == null)
            throw new ArgumentException();


        List<string> slices = new List<string>();

        for (int i=0; i<= numbers.Length-sliceLength; i++)
        {
           slices.Add(numbers.Substring(i, sliceLength));  
        }
        return slices.ToArray();
    }
}