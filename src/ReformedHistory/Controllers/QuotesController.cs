using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReformedHistory.Models;

namespace ReformedHistory.Controllers;

public class QuotesController : Controller {
    private readonly ILogger<ILogger> logger;

    public QuotesController(ILogger<ILogger> logger) {
        this.logger = logger;
    }

    public IActionResult Index() {
        return View();
    }

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}