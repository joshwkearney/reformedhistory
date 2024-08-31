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
    Confession = 0b00001, 
    Council    = 0b00010, 
    Letter     = 0b00100,
    Sermon     = 0b01000,
    Catechism  = 0b10000
}

[Flags]
public enum TimelineEventEra {
    None        = 0,
    Reformation = 0b0001, 
    Medieval    = 0b0010, 
    Ancient     = 0b0100,
    Genesis     = 0b1000
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