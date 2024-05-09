using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList() => new List<string>();


    public static List<string> GetExistingLanguages()
    {
        string[] languages = { "C#", "Clojure", "Elm" };
        List<string> existingList = new List<string>(languages);
        return existingList;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages) => languages.Count;


    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);


    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0)
            return false;
        else if (languages[0] == "C#" || (languages[1] == "C#" && languages.Count > 1 && languages.Count < 4))
            return true;
        else
            return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages) => languages.Distinct().Count() == languages.Count();
 
}
