﻿using System;

public static class TwoFer
{
    public static string Speak()
    {
		return "One for you, one for me.";	
    }

	public static string Speak(string name)
	{
		return String.Format("One for {0}, one for me.", name);
	}
}