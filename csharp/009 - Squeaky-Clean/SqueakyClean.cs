using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();

        bool caseFlag = false;
        
        foreach (char character in identifier)
        {
            if (character == ' ')
            {
                sb.Append("_");
            }
            else if (character == '\0')
            {
                sb.Append("CTRL");
            }
            else if (character == '-')
            {
                caseFlag = true;
            }
            else if (caseFlag == true)
            {
                sb.Append(char.ToUpper(character));
                caseFlag = false;
            }
            else if (char.IsLetter(character) && !char.IsBetween(character, 'α', 'ω'))  
            {
                sb.Append(character);
            }  
        }

        return sb.ToString();
    }
}