using System;

static class LogLine
{
    public static string Message(string logLine) => logLine.Split(':')[1].Trim();

    public static string LogLevel(string logLine) 
    {
        char[] charsToTrim = { '[', ']' };
        return logLine.Split(':')[0].ToLower().Trim(charsToTrim);
    } 

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
