using System;
using System.Text;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {   
        StringBuilder newString = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
        {
            char currentChar = Char.ToLower(word[i]);
            if (!Char.IsLetter(currentChar))
            {   
                newString.Append(currentChar);
                continue;
            }
            else if (newString.ToString().IndexOf(currentChar) >= 0)
            {
                return false;
            }
            else
            {
                newString.Append(currentChar);
            }
        }
        return true;
    }
}
