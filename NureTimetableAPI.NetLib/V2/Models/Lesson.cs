namespace NureTimetableAPI.DotNetLib.V2.Models;

public class Lesson
{
    public int Id { get; set; }

    public string Brief { get; set; } = "";

    public string Title { get; set; } = "";

    public int StartTime { get; set; }

    public int EndTime { get; set; }

    public LessonType Type { get; set; } = new LessonType();

    public int NumberPair { get; set; }

    public List<Teacher> Teachers { get; set; } = [];

    public Auditory Auditory { get; set; } = new Auditory();

    public List<Group> Groups { get; set; } = [];
}
