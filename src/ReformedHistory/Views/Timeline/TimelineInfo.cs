namespace ReformedHistory.Models;

[Flags]
public enum TimelineEventTradition {
    None      = 0,
    Lutheran  = 0b01, 
    Calvinist = 0b10
}

[Flags]
public enum TimelineEventType {
    None     = 0,
    Document = 0b001, 
    Council  = 0b010, 
    Letter   = 0b100
}

[Flags]
public enum TimelineEventEra {
    None        = 0,
    Reformation = 0b001, 
    Medieval    = 0b010, 
    Ancient     = 0b100
}

public abstract record TimelineInfo {
    private TimelineInfo() { }

    public record Event : TimelineInfo {
        public required string Title { get; init; }

        public required int DateStart { get; init; }

        public required int DateEnd { get; init; }

        public required string Description { get; init; }

        public required string Url { get; init; }
        
        public required TimelineEventTradition Tradition { get; init; }
        
        public required TimelineEventType Type { get; init; }
        
        public required TimelineEventEra Era { get; init; }
    }

    public record Era : TimelineInfo {
        public required string Title { get; init; }

        public required int Date { get; init; }
    }
}