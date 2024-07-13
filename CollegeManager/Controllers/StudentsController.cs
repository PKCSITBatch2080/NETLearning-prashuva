using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class StudentsController : Controller
{
    private readonly CollegeManagerDb _context;

    public StudentsController(CollegeManagerDb context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        //CollegeManagerDb db = new CollegeManagerDb();
        var students = _context.Students.Include(s => s.CollegeProgram).ToList();
        return View(students);
    }
 
 [HttpGet]
    public IActionResult Create()
    {
        //CollegeManagerDb db = new CollegeManagerDb();
        ViewBag.CollegeProgramList = new SelectList(_context.CollegePrograms, "Id", "Name");
        return View();
    }

[HttpPost]
    public IActionResult Create(Student student)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                var innerException = ex.InnerException;
                // Log the exception details for debugging
                Console.WriteLine($"DbUpdateException: {ex.Message}");
                Console.WriteLine($"Inner Exception: {innerException?.Message}");
                throw; // Rethrow the exception or handle it accordingly
            }
        }

        // If ModelState is not valid, redisplay the form with validation errors
        return View(student);
    }


    [HttpGet]
    public IActionResult Edit(int id)
    {
        //CollegeManagerDb db = new CollegeManagerDb();
        var students = _context.Students.Find(id);
        ViewBag.CollegeProgramId = new SelectList(_context.CollegePrograms,"Id","Name");
        return View(students);
    } 
    [HttpPost]
    public IActionResult Edit(Student student)
    {
        //CollegeManagerDb db = new CollegeManagerDb();
        var students = _context.Students.Update(student);
        _context.SaveChanges();
        return RedirectToAction("Index");
    } 
    [HttpGet]
    public IActionResult Delete(int id)
    {
        //CollegeManagerDb db = new CollegeManagerDb();
        var students = _context.Students.Include(s => s.CollegeProgram)
        .FirstOrDefault(m => m.Id ==id);
        return View(students);
    }

    [HttpPost]

    public IActionResult Delete(Student student) //model binding
    {
        //CollegeManagerDb db = new CollegeManagerDb();

        var models = _context.Students.Remove(student);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}