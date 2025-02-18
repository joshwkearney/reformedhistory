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

    public IActionResult Confessions(string id) {
        return View("Confessions/" + id);
    }
    
    public IActionResult Councils(string id) {
        return View("Councils/" + id);
    }
    public IActionResult Letters(string id) {
        return View("Letters/" + id);
    }
    
    public IActionResult Catechisms(string id) {
        return View("Catechisms/" + id);
    }
    
    public IActionResult Sermons(string id) {
        return View("Sermons/" + id);
    }

    public IActionResult Commentaries(string id)
    {
        return View("Commentaries/" + id);
    }
}