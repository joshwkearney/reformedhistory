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

    [HttpGet]
    public IActionResult Index() {
        return View();
    }

    [HttpGet]
    [HttpPost]
    public IActionResult Content([FromForm] TimelineContentRequest request) {
        var tradition = TimelineEventTradition.None;
        var type = TimelineEventType.None;
        var era = TimelineEventEra.None;

        if (!string.IsNullOrWhiteSpace(request.LutheranCheckbox)) {
            tradition |= TimelineEventTradition.Lutheran;
        }
        
        if (!string.IsNullOrWhiteSpace(request.CalvinistCheckbox)) {
            tradition |= TimelineEventTradition.Calvinist;
        }
        
        if (!string.IsNullOrWhiteSpace(request.DocumentCheckbox)) {
            type |= TimelineEventType.Document;
        }
        
        if (!string.IsNullOrWhiteSpace(request.LetterCheckbox)) {
            type |= TimelineEventType.Letter;
        }
        
        if (!string.IsNullOrWhiteSpace(request.CouncilCheckbox)) {
            type |= TimelineEventType.Council;
        }
        
        if (!string.IsNullOrWhiteSpace(request.ReformationCheckbox)) {
            era |= TimelineEventEra.Reformation;
        }
        
        if (!string.IsNullOrWhiteSpace(request.MedievalCheckbox)) {
            era |= TimelineEventEra.Medieval;
        }
        if (!string.IsNullOrWhiteSpace(request.AncientCheckbox)) {
            era |= TimelineEventEra.Ancient;
        }

        var model = new TimelineFilters() {
            Tradition = tradition,
            Type = type,
            Era = era
        };

        return PartialView("Content", model);
    }
}

public record TimelineContentRequest {
    public string CalvinistCheckbox { get; init; } = string.Empty;
    public string LutheranCheckbox { get; init; } = string.Empty;
    public string DocumentCheckbox { get; init; } = string.Empty;
    public string LetterCheckbox { get; init; } = string.Empty;
    public string CouncilCheckbox { get; init; } = string.Empty;
    public string ReformationCheckbox { get; init; } = string.Empty;
    public string MedievalCheckbox { get; init; } = string.Empty;
    public string AncientCheckbox { get; init; } = string.Empty;
}