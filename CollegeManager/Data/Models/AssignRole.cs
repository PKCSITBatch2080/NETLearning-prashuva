using Microsoft.AspNetCore.Identity;

namespace CollegeManager.Data.Models
{
    public class AssignRole
    {
        public string UserId { get; set; }
        public string RoleName { get; set; }
        public List<Student> Users { get; set; }
        public List<IdentityRole> Roles { get; set; }
    }
}
