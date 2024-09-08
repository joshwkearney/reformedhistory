namespace ReformedHistory.Models;

public static class CssConstants {
    public static string BodyBackgroundColor { get; } = "#FFFBF3";

    public static string HeaderColor { get; } = "#343F66";

    public static string HighlightColor { get; } = "white";

    public static string GoldColor { get; } = "#E7C066";
    
    public static string MainContentWidth { get; } = "800px";

    public static string HeaderHeight { get; } = "3.5rem";

    public static string DocumentFont { get; } = "'EB Garamond', serif";
    
    public static string SidebarSize => $"400px";

    public static string TwoColumnsMediaQuery => $"max-width: calc(2 * {MainContentWidth})";

    public static string OneColumnMediaQuery => $"max-width: calc(1.5 * {MainContentWidth})";
    
    public static string SubOneColumnMediaQuery => $"max-width: {MainContentWidth}";

    /* Dark Mode */
    public static string DarkModeBackgroundColor { get; } = "#141414";

    public static string DarkModeTextColor {  get; } = "#DDD";


}