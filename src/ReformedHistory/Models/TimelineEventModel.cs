namespace ReformedHistory.Models;

public record TimelineEventModel {
    public required string Title { get; init; }
    
    public required string Date { get; init; }
    
    public required string Description { get; init; }


    // TODO: create a common data structure for documents that we can store here too
    public required string Category { get; init; }

    public required string DocumentId { get; init; }
}