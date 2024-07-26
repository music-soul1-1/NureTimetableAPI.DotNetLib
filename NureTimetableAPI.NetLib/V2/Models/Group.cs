namespace NureTimetableAPI.DotNetLib.V2.Models;

public class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public Entity Direction { get; set; } = new Entity();

    public Entity Faculty { get; set; } = new Entity();
}
