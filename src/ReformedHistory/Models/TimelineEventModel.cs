namespace ReformedHistory.Models;

public record TimelineEventModel {
    public required string Title { get; init; }
    
    public required int DateStart { get; init; }
    
    public required int DateEnd { get; init; }
    
    public required string Description { get; init; }
    
    public required string Url { get; init; }
}