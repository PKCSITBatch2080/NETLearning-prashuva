using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class StudentsController : Controller
{
    public IActionResult Index()
    {
        CollegeManagerDb db = new();
        var students = db.Students.Include(s => s.CollegeProgram).ToList();
        return View(students);
    }
 
 [HttpGet]
    public IActionResult Create()
    {
        CollegeManagerDb db = new();
        ViewBag.CollegeProgramList = new SelectList(db.CollegePrograms, "Id", "Name");
        return View();
    }

[HttpPost]
    public IActionResult Create(Student student)
    {
        CollegeManagerDb db = new();
        var students = db.Students.Add(student);
        db.SaveChanges();
        return RedirectToAction("Index");
    }  

    [HttpGet]
    public IActionResult Edit(int id)
    {
        CollegeManagerDb db = new();
        var students = db.Students.Find(id);
        ViewBag.CollegeProgramId = new SelectList(db.CollegePrograms,"Id","Name");
        return View(students);
    } 
    [HttpPost]
    public IActionResult Edit(Student student)
    {
        CollegeManagerDb db = new();
        var students = db.Students.Update(student);
        db.SaveChanges();
        return RedirectToAction("Index");
    } 
    [HttpGet]
    public IActionResult Delete(int id)
    {
         CollegeManagerDb db = new();
        var students = db.Students.Include(s => s.CollegeProgram)
        .FirstOrDefault(m => m.Id ==id);
        return View(students);
    }

    [HttpPost]

    public IActionResult Delete(Student student) //model binding
    {
        CollegeManagerDb db = new();
        var models = db.Students.Remove(student);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
}