namespace NureTimetableAPI.DotNetLib.V2.Models;

public class TeachersFaculty
{
    public int Id { get; set; }

    public string ShortName { get; set; } = "";

    public string FullName { get; set; } = "";

    public List<Department> Departments { get; set; } = [];
}
