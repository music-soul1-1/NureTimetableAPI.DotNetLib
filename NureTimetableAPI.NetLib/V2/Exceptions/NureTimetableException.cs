namespace NureTimetableAPI.DotNetLib.V2.Exceptions;

[Serializable]
internal class NureTimetableException : Exception
{
    public NureTimetableException()
    {
    }

    public NureTimetableException(string? message) : base(message)
    {
    }

    public NureTimetableException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public NureTimetableException(HttpRequestException? innerException) : base("Failed to make a request to the API", innerException)
    {
    }
}