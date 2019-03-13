using System;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> proverb = new List<string>();

        if (subjects.Length == 1)
            proverb.Add(EndingPart(subjects[0]));
        else if (subjects.Length !=0)
        {
            for (int i=0; i<subjects.Length-1; i++)
            {
                proverb.Add(StandardPart(subjects[i], subjects[i + 1]));
            };
            proverb.Add(EndingPart(subjects[0]));
        }

        return proverb.ToArray();

    }

    private static string StandardPart(string prevSubj, string nextSubj)
    {
        return $"For want of a {prevSubj} the {nextSubj} was lost.";
    }

    private static string EndingPart(string subject)
    {
        return $"And all for the want of a {subject}.";
    }
}