namespace ReformedHistory.Models;

public class TimelineFilters {
    public required TimelineEventTradition Tradition { get; init; }
    
    public required TimelineEventType Type { get; init; }
    
    public required TimelineEventEra Era { get; init; }
}