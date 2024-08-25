using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using NureTimetableAPI.DotNetLib.V2;
using NureTimetableAPI.DotNetLib.V2.Types;

namespace NureTimetableAPI.DotNetLib.Tests.V2;

[TestClass()]
public class NureTimetableTests
{
    [TestMethod()]
    public async Task AllAuditoriesAsyncMethodsTest()
    {
        var allAuditories = await NureTimetable.GetAllAuditoriesAsync();

        Assert.IsNotNull(allAuditories);

        Assert.IsTrue(allAuditories.Count > 0);

        Assert.IsNotNull(await NureTimetable.GetAuditoryByIdAsync(allAuditories.First().Id));

        var auditoriesWithName = await NureTimetable.GetAuditoriesByNameAsync(allAuditories.First().Name);

        Assert.IsNotNull(auditoriesWithName);

        Assert.IsTrue(auditoriesWithName.Count > 0);

        var buildings = await NureTimetable.GetAllBuildingsAsync();

        Assert.IsNotNull(buildings);

        Assert.IsTrue(buildings.Count > 0);

        Assert.IsNotNull(await NureTimetable.GetBuildingByIdAsync(buildings.First().Id));

        var buildingsWithName = await NureTimetable.GetBuildingsByNameAsync(buildings.First().ShortName);

        Assert.IsNotNull(buildingsWithName);

        Assert.IsTrue(buildingsWithName.Count > 0);

        Logger.LogMessage($"Auditories count: {allAuditories.Count}");
    }

    [TestMethod()]
    public async Task AllGroupsAsyncMethodsTest()
    {
        var allGroups = await NureTimetable.GetAllGroupsAsync();

        Assert.IsNotNull(allGroups);

        Assert.IsTrue(allGroups.Count > 0);

        Assert.IsNotNull(await NureTimetable.GetGroupByIdAsync(allGroups.First().Id));

        var groupsWithName = await NureTimetable.GetGroupsByNameAsync(allGroups.First().Name);

        Assert.IsNotNull(groupsWithName);

        Assert.IsTrue(groupsWithName.Count > 0);

        var faculties = await NureTimetable.GetAllGroupsFacultiesAsync();

        Assert.IsNotNull(faculties);

        Assert.IsTrue(faculties.Count > 0);

        Assert.IsNotNull(await NureTimetable.GetGroupsFacultyByIdAsync(faculties.First().Id));

        var facultiesWithName = await NureTimetable.GetGroupsFacultiesByNameAsync(faculties.First().ShortName);

        Assert.IsNotNull(facultiesWithName);

        Assert.IsTrue(facultiesWithName.Count > 0);

        Logger.LogMessage($"Groups count: {allGroups.Count}");
    }

    [TestMethod()]
    public async Task AllTeachersAsyncMethodsTest()
    {
        var allTeachers = await NureTimetable.GetAllTeachersAsync();

        Assert.IsNotNull(allTeachers);

        Assert.IsTrue(allTeachers.Count > 0);

        Assert.IsNotNull(await NureTimetable.GetTeacherByIdAsync(allTeachers.First().Id));

        var teachersWithName = await NureTimetable.GetTeachersByNameAsync(allTeachers.First().ShortName);

        Assert.IsNotNull(teachersWithName);

        Assert.IsTrue(teachersWithName.Count > 0);

        var faculties = await NureTimetable.GetAllTeachersFacultiesAsync();

        Assert.IsNotNull(faculties);

        Assert.IsTrue(faculties.Count > 0);

        Assert.IsNotNull(await NureTimetable.GetTeachersFacultyByIdAsync(faculties.First().Id));

        var facultiesWithName = await NureTimetable.GetTeachersFacultiesByNameAsync(faculties.First().ShortName);

        Assert.IsNotNull(facultiesWithName);

        Assert.IsTrue(facultiesWithName.Count > 0);

        Logger.LogMessage($"Teachers count: {allTeachers.Count}");
    }

    [TestMethod()]
    public async Task AllCombinedEntitiesTest()
    {
        var combinedEntities = await NureTimetable.GetAllCombinedEntitiesAsync();

        Assert.IsNotNull(combinedEntities);

        var minimalCombinedEntities = await NureTimetable.GetAllMinimalCombinedEntitiesAsync();

        Assert.IsNotNull(minimalCombinedEntities);

        Logger.LogMessage($"Combined entities count: \nGroups: {combinedEntities.Groups.Count}.\n" +
            $"Teachers: {combinedEntities.Teachers.Count}.\n" +
            $"Auditories: {combinedEntities.Auditories.Count}.");

        Logger.LogMessage($"Minimal combined entities count: \nGroups: {minimalCombinedEntities.Groups.Count}.\n" +
            $"Teachers: {minimalCombinedEntities.Teachers.Count}.\n" +
            $"Auditories: {minimalCombinedEntities.Auditories.Count}.");
    }

    [TestMethod()]
    public async Task AllLessonsAsyncMethodsTest()
    {
        var lessonsGotById = await NureTimetable.GetLessonsByIdAsync(10307432);

        Assert.IsNotNull(lessonsGotById);

        var lessonsGotByName = await NureTimetable.GetLessonsByNameAsync("Лемешко О. В.", UniEntityType.Teacher);

        Assert.IsNotNull(lessonsGotByName);

        Logger.LogMessage($"Lessons that were retrieved by group ID count: {lessonsGotById.Count}");

        Logger.LogMessage($"Lessons that were retrieved by teacher name count: {lessonsGotByName.Count}");
    }
}