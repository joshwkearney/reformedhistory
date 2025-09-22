namespace ReformedHistory.Models;

[Flags]
public enum TimelineEventTradition {
    None      = 0,
    Lutheran  = 0b001, 
    Reformed = 0b010,
    Anglican  = 0b100
}

[Flags]
public enum TimelineEventType {
    None       = 0,
    Confession = 0b000001, 
    Council    = 0b000010, 
    Letter     = 0b000100,
    Sermon     = 0b001000,
    Catechism  = 0b010000,
    Commentary = 0b100000
}

[Flags]
public enum TimelineEventEra {
    None        = 0,
    Reformation = 0b001, 
    Medieval    = 0b010, 
    Ancient     = 0b100,
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

    public record EraBoundary : TimelineInfo {
        public required string Title { get; init; }

        public required int Date { get; init; }
        
        public required TimelineEventEra Era { get; init; }
    }
}