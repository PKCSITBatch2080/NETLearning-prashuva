using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ProgramController : Controller
{

    /* CollegeProgram c1 = new() {Id=1, Name="CSIT", Affiliation="TU", Started= DateTime.Now};
     CollegeProgram c2 = new() {Id=2, Name="BIT", Affiliation="KU", Started= DateTime.Now.AddMonths(10)};
     CollegeProgram c3 = new() {Id=3, Name="BIM", Affiliation="PU", Started= DateTime.Now.AddDays(200)};
     CollegeProgram c4 = new() {Id=4, Name="BCA", Affiliation="TU", Started= DateTime.Now.AddYears(-3)};
     */
    // List<CollegeProgram> programs =[
    //     new(){Id=1, Name="CSIT", Affiliation="TU", Started= DateTime.Now},
    //     new(){Id=2, Name="BIT", Affiliation="KU", Started= DateTime.Now.AddMonths(10)},
    //     new(){Id=3, Name="BIM", Affiliation="PU", Started= DateTime.Now.AddDays(200)},
    //     new(){Id=4, Name="BCA", Affiliation="TU", Started= DateTime.Now.AddYears(-3)}
    // ] ;
    private readonly CollegeManagerDb _context;

    public ProgramController(CollegeManagerDb context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        //CollegeManagerDb db = new CollegeManagerDb();

        var models = _context.CollegePrograms.ToList();
        return View(models);
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Add(CollegeProgram program) //model binding
    {
        //CollegeManagerDb db = new CollegeManagerDb();

        var models = _context.CollegePrograms.Add(program);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult Edit(int id)
    {
        //CollegeManagerDb db = new CollegeManagerDb();

        var models = _context.CollegePrograms.Find(id);
        return View(models);
    }

    [HttpPost]

    public IActionResult Edit(CollegeProgram program) //model binding
    {
        //CollegeManagerDb db = new CollegeManagerDb();

        var models = _context.CollegePrograms.Update(program);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        //CollegeManagerDb db = new CollegeManagerDb();

        var models = _context.CollegePrograms.Find(id);
        return View(models);
    }

    [HttpPost]

    public IActionResult Delete(CollegeProgram program) //model binding
    {
        //CollegeManagerDb db = new CollegeManagerDb();
        var models = _context.CollegePrograms.Remove(program);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}