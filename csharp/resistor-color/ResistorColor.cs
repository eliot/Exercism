using System;
using System.Collections.Generic;

public static class ResistorColor
{
    private static Dictionary<string, int> colorMap = new Dictionary<string, int> {
        { "black", 0 },
        { "brown", 1 },
        { "red", 2 },
        { "orange", 3 },
        { "yellow", 4 },
        { "green", 5 },
        { "blue", 6 },
        { "violet", 7 },
        { "grey", 8 },
        { "white", 9 }
    };

    public static int ColorCode(string color)
    {
        return ResistorColor.colorMap[color];
    }

    public static string[] Colors()
    {
        string[] keys = new string[ResistorColor.colorMap.Keys.Count];
        ResistorColor.colorMap.Keys.CopyTo(keys, 0);
        return keys;
    }
}