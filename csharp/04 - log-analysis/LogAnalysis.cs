using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delim) => str.Split(delim)[1];

    public static string SubstringBetween(this string str, string start, string end) => str.Split(start)[1].Split(end)[0];
    
    public static string Message(this string str) => str.Split(": ")[1];

    public static string LogLevel(this string str)
    {   
        str = str.Split(": ")[0];
        str = str.Remove(0 , 1);
        str = str.Remove(str.Length - 1, 1);
        return str;
    }
}