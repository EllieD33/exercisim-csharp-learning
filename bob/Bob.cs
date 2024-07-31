using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        string shoutingPattern = @"[a-zA-Z]";
        Regex shoutingRegex = new Regex(shoutingPattern);
        string silencePattern = @"^\s+$";
        Regex silenceRegex = new Regex(silencePattern);

        statement = statement.Trim();

        if (statement == "" || silenceRegex.IsMatch(statement))
        {
            return "Fine. Be that way!";
        }

        bool isShouting = shoutingRegex.IsMatch(statement) && statement.ToUpper() == statement;
        bool isQuestion = statement.EndsWith('?');

        if (isQuestion)
        {
            if (isShouting)
            {
                return "Calm down, I know what I'm doing!";
            }
            else
            {
                return "Sure.";
            }
        }
        else if (isShouting)
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }
    }
}