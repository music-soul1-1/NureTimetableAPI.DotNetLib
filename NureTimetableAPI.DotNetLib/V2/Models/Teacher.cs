namespace NureTimetableAPI.DotNetLib.V2.Models;

public class Teacher
{
    public int Id { get; set; }

    public string ShortName { get; set; } = "";

    public string FullName { get; set; } = "";

    public Entity Department { get; set; } = new();

    public Entity Faculty { get; set; } = new();
}
