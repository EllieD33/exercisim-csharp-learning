using System;
using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        StringBuilder reversedString = new StringBuilder();

        for (int i = input.Length - 1; i >= 0 ; i--)
        {
            reversedString.Append(input[i]);
        }

        return reversedString.ToString();
    }
}