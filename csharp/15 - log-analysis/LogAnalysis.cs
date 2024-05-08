using System;
public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delim) => str.Split(delim)[1];
    
    public static string SubstringBetween(this string str, string delimStart, string delimEnd) => str.Split(delimStart)[1].Split(delimEnd)[0];
    
    public static string Message(this string str) => str.Split(":")[1].Trim();

    public static string LogLevel(this string str)
    {
        char[] charsToTrim = { '[', ']'};
        return str.Split(":")[0].Trim(charsToTrim);
    }
}