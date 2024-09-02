namespace ReformedHistory.Models;

public static class CssConstants {
    public static string BodyBackgroundColor { get; } = "#FFFBF3";

    public static string HeaderColor { get; } = "#343F66";

    public static string HighlightColor { get; } = "white";

    public static string GoldColor { get; } = "#E7C066";
    
    public static string MainContentWidth { get; } = "800px";

    public static string HeaderHeight { get; } = "3.5rem";

    public static string DocumentFont { get; } = "'EB Garamond', serif";

    public static string ColumnSpacing { get; } = "2rem";

    public static string TwoColumnsMediaQuery => $"max-width: calc({MainContentWidth} * 2 + {ColumnSpacing} * 2)";

    public static string OneColumnMediaQuery => $"max-width: calc({MainContentWidth} * 1.5 + {ColumnSpacing})";
}