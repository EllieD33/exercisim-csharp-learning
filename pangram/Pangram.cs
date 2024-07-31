using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string lowercaseInput = input.ToLower();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        for (int i = 0; i < alphabet.Length; i++)
        {
            if (!lowercaseInput.Contains(alphabet[i]))
            {
                return false;
            }
        }
        return true;
    }
}
