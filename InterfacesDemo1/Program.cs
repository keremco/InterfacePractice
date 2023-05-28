IDatabase db = new OracleDatabase();
db.Create();
db.Read();

interface IDatabase
{
    string Name { get; set; }
    void Create();
    void Update();

    void Delete();

    void Read();
}

class SqlServerDatabase : IDatabase
{
    public string Name { get; set; }

    public void Create()
    {
        Console.WriteLine("Created SQL");
    }

    public void Delete()
    {
        Console.WriteLine("Deleted SQL");
    }

    public void Read()
    {
        Console.WriteLine("Read SQL");
    }

    public void Update()
    {
        Console.WriteLine("Update SQL");
    }
}

class OracleDatabase : IDatabase
{
    public string Name { get; set; }

    public void Create()
    {
        Console.WriteLine("Created Oracle");
    }

    public void Delete()
    {
        Console.WriteLine("Delete Oracle");
    }

    public void Read()
    {
        Console.WriteLine("Read Oracle");
    }

    public void Update()
    {
        Console.WriteLine("Update Oracle");
    }
}