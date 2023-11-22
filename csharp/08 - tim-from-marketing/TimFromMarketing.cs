using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        department ??= "owner";
        return id.HasValue switch {
            true => $"[{id}] - {name} - {department.ToUpper()}",
            false => $"{name} - {department.ToUpper()}",
        };
    }
}
