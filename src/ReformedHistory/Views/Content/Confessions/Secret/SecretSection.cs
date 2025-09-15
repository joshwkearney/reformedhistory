namespace ReformedHistory.Views.Content.Confessions.Secret;

public record SecretSection {
    public string Name { get; init; } = string.Empty;

    public string View { get; init; } = string.Empty;
    
    public string SourcesView { get; init; } = string.Empty;

    public string Link { get; init; } = string.Empty;
    
    public int Index { get; init; }

    public bool GroupEnd { get; init; } = false;
}