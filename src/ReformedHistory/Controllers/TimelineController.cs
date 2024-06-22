using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReformedHistory.Models;

namespace ReformedHistory.Controllers;

[Controller]
public class TimelineController : Controller {
    private readonly ILogger<TimelineController> logger;

    public TimelineController(ILogger<TimelineController> logger) {
        this.logger = logger;
    }

    public IActionResult Index() {
        return View();
    }
}