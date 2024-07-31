using System;
using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder encryptedText = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char character = text[i];
            if (Char.IsLetter(character))
            {
                char offset = char.IsUpper(character) ? 'A' : 'a';
                char rotatedChar = (char)((character - offset + shiftKey) % 26 + offset);
                encryptedText.Append(rotatedChar);
            }
            else
            {
                encryptedText.Append(character);
            }
        }
        return encryptedText.ToString();
    }
}