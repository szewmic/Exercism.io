using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> transformedDict = new Dictionary<string, int>();

        foreach(int i in old.Keys)
        {
            foreach(string s in old[i])
            {
                transformedDict.Add(s.ToLower(), i);
            }
        }

        return transformedDict;
    }
}