using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (String.IsNullOrEmpty(word))
            return true;

        word = word.ToLower();

        HashSet<char> letter_count = new HashSet<char>();

        foreach (char c in word)
        {
            if (Char.IsLetter(c))
            {
                if (letter_count.Contains(c))
                    // duplicate letter; not an isogram
                    return false;
                else
                    letter_count.Add(c);
            }
        }

        return true;
    }
}
