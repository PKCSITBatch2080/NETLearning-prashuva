using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
public class CollegeProgram
{
    public int Id{get; set;}
    public string? Name{get; set;}

    public string? Affiliation{get; set;}
    public DateTime Started{get; set;}
}