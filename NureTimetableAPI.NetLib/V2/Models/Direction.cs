﻿namespace NureTimetableAPI.DotNetLib.V2.Models;

public class Direction
{
    public int Id { get; set; }

    public string ShortName { get; set; } = "";

    public string FullName { get; set; } = "";

    public List<MinimalGroup> Groups { get; set; } = [];
}
