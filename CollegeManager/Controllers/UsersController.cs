using CollegeManager.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{
    private readonly UserManager<Student> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public UsersController(UserManager<Student> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    // GET: Users/AssignRole
    public async Task<IActionResult> AssignRole()
    {
        var model = new AssignRole
        {
            Users =  _userManager.Users.ToList(),
            Roles = _roleManager.Roles.ToList()
        };
        return View(model);
    }

    // POST: Users/AssignRole
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AssignRole(AssignRole model)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                ModelState.AddModelError("", "User not found.");
                return View(model);
            }

            var roleExists = await _roleManager.RoleExistsAsync(model.RoleName);
            if (!roleExists)
            {
                ModelState.AddModelError("", "Role not found.");
                return View(model);
            }

            var result = await _userManager.AddToRoleAsync(user, model.RoleName);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
        model.Users =  _userManager.Users.ToList();
        model.Roles =  _roleManager.Roles.ToList();
        return View(model);
    }
}
