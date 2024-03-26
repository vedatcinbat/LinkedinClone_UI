﻿namespace JobNet.CoreApi.Data.Entities;

public class School
{
    public int SchoolId { get; set; }
    
    public string SchoolName { get; set; }
    
    public string Location { get; set; }
    
    public DateTime EstablishedAt { get; set; }
    
    public List<User> Graduates { get; set; } = new List<User>();
}