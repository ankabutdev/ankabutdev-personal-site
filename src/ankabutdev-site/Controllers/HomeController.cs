using ankabutdev_site.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ankabutdev_site.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult AboutUs()
    {
        return View();
    }

    public IActionResult Articles()
    {
        return View();
    }

    public IActionResult Profile()
    {
        return View();
    }

    public IActionResult Settings()
    {
        return View();
    }

    public IActionResult Contacts()
    {
        return View();
    }

    public IActionResult Blogs()
    {
        return View();
    }
}
