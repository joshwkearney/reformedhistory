namespace ReformedHistory.Models;

public record TimelineEventModel {
    public required string Title { get; init; }
    
    public required string Date { get; init; }
    
    public required string Description { get; init; }
}