namespace NureTimetableAPI.DotNetLib.V2.Models;

public class LessonType
{
    public int Id { get; set; }

    public string ShortName { get; set; } = "";

    public string FullName { get; set; } = "";

    public int IdBase { get; set; }

    public string Type { get; set; } = "";
}
