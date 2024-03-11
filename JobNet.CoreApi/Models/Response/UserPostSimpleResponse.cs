﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobNet.CoreApi.Models.Response;

public class UserPostSimpleResponse
{
    [Key]
    public int UserId { get; set; }
    
    public string? Firstname { get; set; }
    
    public string? Lastname { get; set; }
    
    public string? Title { get; set; }
    
    public string? ProfilePictureUrl { get; set; }
    
    public bool IsDeleted { get; set; }
    
    [ForeignKey("CompanyId")]
    public int? CompanyId { get; set; }
    
    public UserPostCompanySimpleResponse? Company { get; set; }
}