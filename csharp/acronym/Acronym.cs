using System;
using System.Linq;

public static class Acronym
{
    private static char[] delimiterChars = { ' ', '-' };
    public static string Abbreviate(string phrase)
    {
        var words = phrase
            .Replace('_', ' ')
            .Split(Acronym.delimiterChars, 
                   StringSplitOptions.RemoveEmptyEntries);
        
        string firstLetters = new string(
            words
                .Select(s => s[0])
                .ToArray());

        return firstLetters.ToUpper();
    }
}