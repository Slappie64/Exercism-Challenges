using System;

public class Orm
{
    private Database database;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Write(string data)
    {
        try
        {
            Console.WriteLine("Errr");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    public bool WriteSafely(string data)
    {
        throw new NotImplementedException($"Please implement the Orm.WriteSafely() method");
    }
}
