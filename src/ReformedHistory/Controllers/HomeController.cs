using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReformedHistory.Models;

namespace ReformedHistory.Controllers;

public class HomeController : Controller {
    private readonly ILogger<HomeController> logger;

    public HomeController(ILogger<HomeController> logger) {
        this.logger = logger;
    }

    public IActionResult Index() {
        return View();
    }

    public IActionResult Privacy() {
        return View();
    }

	public IActionResult Library() {
		return View();
	}

	public IActionResult Document(string category, string id) {
		if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(id)) {
			return NotFound();
		}
		
		return View($"{category}/{id}");
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}