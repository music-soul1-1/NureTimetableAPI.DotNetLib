namespace NureTimetableAPI.DotNetLib.V2.Models;


/// <summary>
/// Holds minimal groups, teachers and auditories in a single object.
/// </summary>
public class MinimalCombinedEntities
{
    public List<MinimalGroup> Groups { get; set; } = [];

    public List<MinimalTeacher> Teachers { get; set; } = [];

    public List<MinimalAuditory> Auditories { get; set; } = [];
}
