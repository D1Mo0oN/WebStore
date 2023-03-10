using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers;

public class HomeController : Controller
{
    private static readonly List<Employee> __Employees = new()
    {
        new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 23, Height = 175 },
        new Employee { Id = 2, LastName = "Петров", FirstName = "Пётр", Patronymic = "Петрович", Age = 27, Height = 180 },
        new Employee { Id = 3, LastName = "Сидоров", FirstName = "Сидр", Patronymic = "Сидорович", Age = 18, Height = 167 },
    };

    public IActionResult Index()
    {
        //return Content("Данные из первого контроллера");
        return View();
    }

    public string ConfiguredAction(string id,string Value1)
    {
        return $"Hello World! {id} - {Value1  }";
    }

    public IActionResult Employees()
    {
        return View(__Employees);
    }
}
