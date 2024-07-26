namespace NureTimetableAPI.DotNetLib.V2.Models;

public class GroupsFaculty
{
    public int Id { get; set; }

    public string ShortName { get; set; } = "";

    public string FullName { get; set; } = "";

    public List<Direction> Directions { get; set; } = [];
}
