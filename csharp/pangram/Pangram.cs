using System;
using System.Collections.Generic;

public static class Pangram
{
    public static HashSet<char> alphabet = new HashSet<char> { 'a', 'b', 'c', 'd',
        'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
        'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };    

    public static bool IsPangram(string input)
    {
        HashSet<char> letters = new HashSet<char>(Pangram.alphabet);

        foreach (char c in input)
        {
            try
            {
                letters.Remove(Char.ToLower(c));
            }
            finally
            {}
        }

        if (letters.Count > 0)
            return false;
        return true;
    }
}
