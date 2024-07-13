
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class CollegeManagerDb: IdentityDbContext
{
    public CollegeManagerDb(DbContextOptions<CollegeManagerDb> options)
        : base(options)
    {
    }
    public DbSet<CollegeProgram> CollegePrograms { get; set; }
    public DbSet<Student> Students { get; set; }
    //Adds tables named CollegePrograms in CollegeManager.db
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlite("Data Source = CollegeManager.db"); //connection string set gareko
    //}
}