namespace ReformedHistory.Models;

public class TimelineFilters {
    public static TimelineFilters Default { get; } = new TimelineFilters() {
        TextSearch = string.Empty,
        Tradition = TimelineEventTradition.Reformed,
        Era = TimelineEventEra.Ancient 
            | TimelineEventEra.Medieval 
            | TimelineEventEra.Reformation,
        Type = TimelineEventType.Catechism
            | TimelineEventType.Confession
            | TimelineEventType.Council
            | TimelineEventType.Letter
            | TimelineEventType.Sermon
    };
    
    public required string TextSearch { get; init; }
    
    public required TimelineEventTradition Tradition { get; init; }
    
    public required TimelineEventType Type { get; init; }
    
    public required TimelineEventEra Era { get; init; }
}