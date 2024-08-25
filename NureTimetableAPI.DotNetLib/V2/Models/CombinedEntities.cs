namespace NureTimetableAPI.DotNetLib.V2.Models;

/// <summary>
/// Holds groups, teachers and auditories in one object.
/// </summary>
public class CombinedEntities
{
    public List<Group> Groups { get; set; } = [];

    public List<Teacher> Teachers { get; set; } = [];

    public List<Auditory> Auditories { get; set; } = [];
}
