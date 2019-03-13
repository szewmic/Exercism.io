using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private string baseWord;

    public Anagram(string baseWord)
    {
        this.baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> matchingWords = new List<string>();
        string sortedBaseWord = string.Concat(baseWord.ToLower().OrderByDescending(s => s));

        foreach (string wordToCheck in potentialMatches.ToArray())
        {
            var sortedWordToCheck = string.Concat(wordToCheck.ToLower().OrderByDescending(s => s));
            if (sortedWordToCheck.Equals(sortedBaseWord) && !baseWord.ToLower().Equals(wordToCheck.ToLower()))
                matchingWords.Add(wordToCheck);
        }
      
        return matchingWords.ToArray();
    }
}