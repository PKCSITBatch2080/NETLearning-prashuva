
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Student: IdentityUser
{
 public int Id{ get; set; }
    [Required(ErrorMessage = "Enter your name")]
    [Display(Name = "Name")]
    [StringLength(50)]
    public string Name{ get; set; } = string.Empty;
    [Required(ErrorMessage = "Enter your address")]
    [Display(Name = "Address")]
    [StringLength(100)]
    public string? Address{ get; set; }
    [Required]
    [StringLength(50)]
    [DataType(DataType.EmailAddress)]
    public string? Email{ get; set; }
    [Required]
    public DateTime? Dob{ get; set; }

//[ForeignKey]
public int CollegeProgramId{ get; set; }
public CollegeProgram? CollegeProgram{ get; set; }
}