namespace NureTimetableAPI.DotNetLib.V2.Models;

public class Building
{
    public string Id { get; set; } = "";

    public string ShortName { get; set; } = "";

    public string FullName { get; set; } = "";

    public List<MinimalAuditory> Auditories { get; set; } = [];
}
