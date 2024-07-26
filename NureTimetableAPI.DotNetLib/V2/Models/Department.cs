namespace NureTimetableAPI.DotNetLib.V2.Models;

public class Department
{
    public int Id { get; set; }

    public string ShortName { get; set; } = "";

    public string FullName { get; set; } = "";

    public List<MinimalTeacher> Teachers { get; set; } = [];
}
