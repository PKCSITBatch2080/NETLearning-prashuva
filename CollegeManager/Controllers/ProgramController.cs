using Microsoft.AspNetCore.Mvc;

public class ProgramController : Controller
{
    public IActionResult Index()
    {
        CollegeProgram c1 = new() {Id=1, Name="CSIT", Affiliation="TU", Started= DateTime.Now};
        CollegeProgram c2 = new() {Id=2, Name="BIT", Affiliation="KU", Started= DateTime.Now.AddMonths(10)};
        CollegeProgram c3 = new() {Id=3, Name="BIM", Affiliation="PU", Started= DateTime.Now.AddDays(200)};
        CollegeProgram c4 = new() {Id=4, Name="BCA", Affiliation="TU", Started= DateTime.Now.AddYears(-3)};
        List<CollegeProgram> program = new() {c1, c2, c3, c4};
        return View(program);
    }
}