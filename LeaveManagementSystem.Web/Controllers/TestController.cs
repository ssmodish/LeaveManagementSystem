using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Bob",
                DateOfBirth = new DateTime(2005, 1, 22)
            };

            return View(data);
        }
    }
}
