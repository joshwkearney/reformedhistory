using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReformedHistory.Models;

namespace ReformedHistory.Controllers;

[Controller]
public class ContentController : Controller {
    private readonly ILogger<ContentController> logger;

    public ContentController(ILogger<ContentController> logger) {
        this.logger = logger;
    }

    public IActionResult Documents(string id) {
        return View("Documents/" + id);
    }
    
    public IActionResult Councils(string id) {
        return View("Councils/" + id);
    }
    public IActionResult Letters(string id) {
        return View("Letters/" + id);
    }
}