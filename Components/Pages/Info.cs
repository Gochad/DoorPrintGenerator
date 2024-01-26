namespace DoorPrintGenerator.Components.Pages;

public class Info
{
    public string? RoomNumber { get; set; }
    public string? Names { get; set; }
    
    public string? RoomNumberFontName { get; set; }
    public string? RoomNumberFontSize { get; set; }
    public string? NamesFontName { get; set; }
    public string? NamesFontSize { get; set; }
    public string? RoomNumberFontColor { get; set; }
    public string? NamesFontColor { get; set; }
    
    public double LogoWidth { get; set; }
    public double LogoHeight { get; set; }
    public double LogoOffsetX { get; set; }
    public double LogoOffsetY { get; set; }
    
    public double RoomNumberOffsetX { get; set; }
    public double RoomNumberOffsetY { get; set; }
    
    public double NamesOffsetX { get; set; }
    public double NamesOffsetY { get; set; }
}