namespace BlazorApp1.Components.Models;
public class CrosswordClue
{
    public string Clue { get; set; } = string.Empty; // Die eigentliche Frage
    public string Answer { get; set; } = string.Empty; // Die Lösung
    public int Row { get; set; } // Startreihe im Grid
    public int Col { get; set; } // Startspalte im Grid
    public bool IsHorizontal { get; set; } // Richtung des Wortes
}