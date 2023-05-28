Console.WriteLine("Hello, World!");

interface IPerson
{
    int Id { get; set; }

    string Name { get; }

    string Surname { get; }

}

interface IDatabase
{
    void Create();
    void Update();  

    void Delete();

    void Read();
}

class SqlServerDatabase : IDatabase
{
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
