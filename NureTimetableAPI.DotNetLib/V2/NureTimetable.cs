using Newtonsoft.Json;
using NureTimetableAPI.DotNetLib.V2.Exceptions;
using NureTimetableAPI.DotNetLib.V2.Models;
using NureTimetableAPI.DotNetLib.V2.Types;

namespace NureTimetableAPI.DotNetLib.V2;

/// <summary>
/// Provides methods to work with 
/// <see href="https://github.com/music-soul1-1/NureTimetableAPI">NureTimetableAPI</see>.
/// </summary>
public class NureTimetable
{
    private static readonly HttpClient _httpClient = new()
    {
        BaseAddress = new Uri("https://nure-time.runasp.net/api/v2/")
    };

    #region Auditories

    /// <summary>
    /// Gets all auditories.
    /// </summary>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a list of <see cref="Auditory"/> objects.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<Auditory>?> GetAllAuditoriesAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("Auditories/GetAll");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get auditories. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<Auditory>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get auditories", ex);
        }
    }

    /// <summary>
    /// Gets an auditory by <paramref name="id"/>.
    /// </summary>
    /// <param name="id">
    /// ID of the auditory.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains an <see cref="Auditory"/> object.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<Auditory?> GetAuditoryByIdAsync(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Auditories/Get/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get auditory by ID. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<Auditory>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get auditory by ID", ex);
        }
    }

    /// <summary>
    /// Gets auditories by <paramref name="name"/>.
    /// </summary>
    /// <param name="name">
    /// Name of the auditory.
    /// </param>
    /// 
    /// <returns>
    /// The task object representing the asynchronous operation. 
    /// <br></br>
    /// The task result contains a list of <see cref="Auditory"/> objects,
    /// where the name of each auditory contains the specified <paramref name="name"/>.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<Auditory>?> GetAuditoriesByNameAsync(string name)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Auditories/GetByName?name={name}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get auditories by name. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<Auditory>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get auditories by name", ex);
        }
    }

    #region Buildings

    /// <summary>
    /// Gets all university buildings.
    /// </summary>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a list of <see cref="Building"/> objects.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<Building>?> GetAllBuildingsAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("Auditories/Buildings/GetAll");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get auditories buildings. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<Building>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get auditories buildings", ex);
        }
    }

    /// <summary>
    /// Gets a university building by <paramref name="id"/>.
    /// </summary>
    /// <param name="id">
    /// ID of the building.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a <see cref="Building"/> object.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<Building?> GetBuildingByIdAsync(string id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Auditories/Buildings/Get/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get auditories building by ID. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<Building>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get auditories building by ID", ex);
        }
    }

    /// <summary>
    /// Gets university buildings by <paramref name="name"/>.
    /// </summary>
    /// <param name="name">
    /// Name of the building.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation. 
    /// <br></br>
    /// The task result contains a list of <see cref="Building"/> objects,
    /// where the name of each building contains the specified <paramref name="name"/>.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<Building>?> GetBuildingsByNameAsync(string name)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Auditories/Buildings/GetByName?name={name}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get auditories buildings by name. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<Building>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get auditories buildings by name", ex);
        }
    }

    #endregion

    #endregion

    #region Groups

    /// <summary>
    /// Gets all groups.
    /// </summary>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a list of <see cref="Group"/> objects.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<Group>?> GetAllGroupsAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("Groups/GetAll");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get groups. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<Group>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get groups", ex);
        }
    }

    /// <summary>
    /// Gets a group by <paramref name="id"/>.
    /// </summary>
    /// <param name="id">
    /// ID of the group.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a <see cref="Group"/> object.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<Group?> GetGroupByIdAsync(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Groups/Get/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get group by ID. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<Group>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get group by ID", ex);
        }
    }

    /// <summary>
    /// Gets groups by <paramref name="name"/>.
    /// </summary>
    /// <param name="name">
    /// Name of the group.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation.
    /// <br></br>
    /// The task result contains a list of <see cref="Group"/> objects,
    /// that contain the specified <paramref name="name"/>.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<Group>?> GetGroupsByNameAsync(string name)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Groups/GetByName?name={name}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get groups by name. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<Group>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get groups by name", ex);
        }
    }

    #region Group faculties

    /// <summary>
    /// Gets all groups faculties.
    /// </summary>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a list of <see cref="GroupsFaculty"/> objects.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<GroupsFaculty>?> GetAllGroupsFacultiesAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("Groups/Faculties/GetAll");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get groups faculties. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<GroupsFaculty>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get groups faculties", ex);
        }
    }

    /// <summary>
    /// Gets a groups faculty by <paramref name="id"/>.
    /// </summary>
    /// <param name="id">
    /// ID of the groups faculty.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a <see cref="GroupsFaculty"/> object.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<GroupsFaculty?> GetGroupsFacultyByIdAsync(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Groups/Faculties/Get/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get groups faculty by ID. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<GroupsFaculty>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get groups faculty by ID", ex);
        }
    }

    /// <summary>
    /// Gets groups faculties by <paramref name="name"/>.
    /// </summary>
    /// <param name="name">
    /// Name of the groups faculty.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation.
    /// <br></br>
    /// The task result contains a list of <see cref="GroupsFaculty"/> objects,
    /// that contain the specified <paramref name="name"/>.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<GroupsFaculty>?> GetGroupsFacultiesByNameAsync(string name)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Groups/Faculties/GetByName?name={name}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get groups faculties by name. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<GroupsFaculty>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get groups faculties by name", ex);
        }
    }

    #endregion

    #endregion

    #region Teachers

    /// <summary>
    /// Gets all teachers.
    /// </summary>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a list of <see cref="Teacher"/> objects.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<Teacher>?> GetAllTeachersAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("Teachers/GetAll");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get teachers. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<Teacher>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get teachers", ex);
        }
    }

    /// <summary>
    /// Gets a teacher by <paramref name="id"/>.
    /// </summary>
    /// <param name="id">
    /// ID of the teacher.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a <see cref="Teacher"/> object.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<Teacher?> GetTeacherByIdAsync(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Teachers/Get/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get teacher by ID. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<Teacher>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get teacher by ID", ex);
        }
    }

    /// <summary>
    /// Gets teachers by <paramref name="name"/>.
    /// </summary>
    /// <param name="name">
    /// Name of the teacher.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation.
    /// <br></br>
    /// The task result contains a list of <see cref="Teacher"/> objects,
    /// that contain the specified <paramref name="name"/>.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<Teacher>?> GetTeachersByNameAsync(string name)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Teachers/GetByName?name={name}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get teachers by name. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<Teacher>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get teachers by name", ex);
        }
    }

    #region Teachers faculties

    /// <summary>
    /// Gets all teachers faculties.
    /// </summary>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a list of <see cref="TeachersFaculty"/> objects.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<TeachersFaculty>?> GetAllTeachersFacultiesAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("Teachers/Faculties/GetAll");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get teachers faculties. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<TeachersFaculty>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get teachers faculties", ex);
        }
    }

    /// <summary>
    /// Gets a teachers faculty by <paramref name="id"/>.
    /// </summary>
    /// <param name="id">
    /// ID of the teachers faculty.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a <see cref="TeachersFaculty"/> object.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<TeachersFaculty?> GetTeachersFacultyByIdAsync(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Teachers/Faculties/Get/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get teachers faculty by ID. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<TeachersFaculty>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get teachers faculty by ID", ex);
        }
    }

    /// <summary>
    /// Gets teachers faculties by <paramref name="name"/>.
    /// </summary>
    /// <param name="name">
    /// Name of the teachers faculty.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation.
    /// <br></br>
    /// The task result contains a list of <see cref="TeachersFaculty"/> objects,
    /// that contain the specified <paramref name="name"/>.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<TeachersFaculty>?> GetTeachersFacultiesByNameAsync(string name)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Teachers/Faculties/GetByName?name={name}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get teachers faculties by name. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<TeachersFaculty>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get teachers faculties faculties by name", ex);
        }
    }

    #endregion

    #endregion

    #region Combined Entities

    public static async Task<CombinedEntities?> GetAllCombinedEntitiesAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("Entities/GetAll");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get combined entities. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<CombinedEntities>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get combined entities", ex);
        }
    }

    public static async Task<MinimalCombinedEntities?> GetAllMinimalCombinedEntitiesAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("Entities/GetAll?useMinimalModels=true");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get minimal combined entities. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<MinimalCombinedEntities>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get minimal combined entities", ex);
        }
    }

    #endregion

    #region Lessons

    /// <summary>
    /// Gets all lessons for the specified entity <paramref name="id"/> and <paramref name="type"/>.
    /// </summary>
    /// <param name="id">
    /// ID of the entity.
    /// </param>
    /// <param name="type">
    /// Type of the entity. Can be a group, teacher or auditory.
    /// </param>
    /// <param name="startTime">
    /// Start time of the schedule. Format: UNIX seconds timestamp.
    /// </param>
    /// <param name="endTime">
    /// End time of the schedule. Format: UNIX seconds timestamp.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a list of <see cref="Lesson"/> objects.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<Lesson>?> GetLessonsByIdAsync(int id, UniEntityType type = UniEntityType.Group, int? startTime = null, int? endTime = null)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Lessons/GetById?id={id}&type={(int)type}&startTime={startTime}&endTime={endTime}");
            
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get lessons by ID. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<Lesson>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get lessons by ID", ex);
        }
    }

    /// <summary>
    /// Gets all lessons for the specified entity <paramref name="name"/> and <paramref name="type"/>.
    /// </summary>
    /// <param name="name">
    /// The name of the entity.
    /// </param>
    /// <param name="type">
    /// Type of the entity. Can be a group, teacher or auditory.
    /// </param>
    /// <param name="startTime">
    /// Start time of the schedule. Format: UNIX seconds timestamp.
    /// </param>
    /// <param name="endTime">
    /// End time of the schedule. Format: UNIX seconds timestamp.
    /// </param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains a list of <see cref="Lesson"/> objects.
    /// </returns>
    /// <exception cref="NureTimetableException"></exception>
    public static async Task<List<Lesson>?> GetLessonsByNameAsync(string name, UniEntityType type = UniEntityType.Group, int? startTime = null, int? endTime = null)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Lessons/GetByName?name={name}&type={(int)type}&startTime={startTime}&endTime={endTime}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to get lessons by name. Status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<List<Lesson>>(await response.Content.ReadAsStringAsync());
        }
        catch (HttpRequestException ex)
        {
            throw new NureTimetableException(ex);
        }
        catch (Exception ex)
        {
            throw new NureTimetableException("Failed to get lessons by name", ex);
        }
    }

    #endregion
}
