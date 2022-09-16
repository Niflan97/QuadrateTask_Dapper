using Microsoft.AspNetCore.Mvc;

namespace DapperWithCRUD.Controllers;

public class MoviesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}