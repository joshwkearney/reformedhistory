namespace ReformedHistory.Models;

public abstract record TimelineInfo {
    private TimelineInfo() { }

    public record Event : TimelineInfo {
        public required string Title { get; init; }

        public required int DateStart { get; init; }

        public required int DateEnd { get; init; }

        public required string Description { get; init; }

        public required string Url { get; init; }
    }

    public record Era : TimelineInfo {
        public required string Title { get; init; }

        public required int Date { get; init; }
    }
}