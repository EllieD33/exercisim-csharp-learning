using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrEmpty(identifier)) return string.Empty;

        StringBuilder cleanIdentifier = new StringBuilder();

        for (int i = 0; i < identifier.Length; i++)
        {
            char currentChar = identifier[i];

            if (currentChar >= '\u03B1' && currentChar <= '\u03C9')
            {
                continue;
            }

            if (Char.IsLetter(currentChar))
            {
                cleanIdentifier.Append(currentChar);
            }
            else if (Char.IsWhiteSpace(currentChar))
            {
                cleanIdentifier.Append('_');
            }
            else if (Char.IsControl(currentChar))
            {
                cleanIdentifier.Append("CTRL");
            }
            if (currentChar == '-')
            {
                if (i + 1 < identifier.Length && Char.IsLetter(identifier[i + 1]))
                {
                    cleanIdentifier.Append(Char.ToUpper(identifier[i + 1]));
                    i++;
                }
            }
        }
        return cleanIdentifier.ToString();
    }
}
