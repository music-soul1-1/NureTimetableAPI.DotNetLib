namespace NureTimetableAPI.DotNetLib.V2.Models;

public class Auditory
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public int Floor { get; set; }

    public bool HasPower { get; set; }

    public List<AuditoryType> AuditoryTypes { get; set; } = [];

    public MinimalBuilding Building { get; set; } = new();
}
