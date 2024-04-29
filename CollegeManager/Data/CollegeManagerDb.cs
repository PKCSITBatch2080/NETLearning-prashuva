using Microsoft.EntityFrameworkCore;

public class CollegeManagerDb: DbContext
{
    public DbSet<CollegeProgram> CollegePrograms { get; set; }
    public DbSet<Student> Students { get; set; }
    //Adds tables named CollegePrograms in CollegeManager.db
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlite("Data Source = CollegeManager.db");
       //Connection string
    }
}