using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class StudentsController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public StudentsController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var students = await client.GetFromJsonAsync<List<Student>>("https://localhost:7107/api/students");
        return View(students);
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var client = _httpClientFactory.CreateClient();
        var collegePrograms = await client.GetFromJsonAsync<List<CollegeProgram>>("https://localhost:7107/api/collegeprograms");
        ViewBag.CollegeProgramList = new SelectList(collegePrograms, "Id", "Name");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Student student)
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.PostAsJsonAsync("https://localhost:7107/api/students", student);
        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(student);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var student = await client.GetFromJsonAsync<Student>($"https://localhost:7107/api/students/{id}");
        var collegePrograms = await client.GetFromJsonAsync<List<CollegeProgram>>("https://localhost:7107/api/collegeprograms");
        ViewBag.CollegeProgramList = new SelectList(collegePrograms, "Id", "Name");
        return View(student);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Student student)
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.PutAsJsonAsync($"https://localhost:7107/api/students/{student.Id}", student);
        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(student);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var student = await client.GetFromJsonAsync<Student>($"https://localhost:7107//api/students/{id}");
        return View(student);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.DeleteAsync($"https://localhost:7107//api/students/{id}");
        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
}
