using LeaveManagementSystem.Web.Models; //1
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers;

public class TestController : Controller
{
    // GET
    public IActionResult Index()
    {
        var data = new TestViewModel()
        {
            Name = "Student of MVC Mastery",
            DateOfBirth = new DateTime(1988, 08, 16),
        };
        return View(data);
    }
}