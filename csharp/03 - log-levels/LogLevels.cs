using System;

static class LogLine
{
    public static string Message(string logLine) => logLine.Split(':')[1].Trim();

    public static string LogLevel(string logLine)
    {
        string lineLevel = logLine.Split(':')[0].ToLower();
        lineLevel = lineLevel.Remove(0,1);
        lineLevel = lineLevel.Remove(lineLevel.Length - 1, 1);
        return lineLevel;
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";

}
