using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReformedHistory.Models;

namespace ReformedHistory.Controllers;

[Controller]
public class DocumentController : Controller {
    private readonly ILogger<DocumentController> logger;

    public DocumentController(ILogger<DocumentController> logger) {
        this.logger = logger;
    }

    public IActionResult Index() {
        return View();
    }
}