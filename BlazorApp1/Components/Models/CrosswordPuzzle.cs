using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace BlazorApp1.Components.Modells;

public class CrosswordPuzzle
{
    [Key]
    public int Id { get; set; }  // Primärschlüssel für die Datenbank

    public string Title { get; set; } = "Unbenanntes Rätsel";

    // Raster des Kreuzworträtsels (2D-Matrix)
    public string GridJson { get; set; } = "{}";

    // Liste der Hinweise und ihrer Positionen
    public string CluesJson { get; set; } = "{}";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Wandelt das gespeicherte JSON in ein char-Array um (Raster)
    /// </summary>
    public char[,] GetGrid()
    {
        return JsonSerializer.Deserialize<char[,]>(GridJson) ?? new char[0, 0];
    }

    /// <summary>
    /// Setzt ein char-Array als Grid und speichert es als JSON
    /// </summary>
    public void SetGrid(char[,] grid)
    {
        GridJson = JsonSerializer.Serialize(grid);
    }

    /// <summary>
    /// Holt die Hinweise aus dem JSON-Format
    /// </summary>
    public List<CrossWordClue> GetClues()
    {
        return JsonSerializer.Deserialize<List<CrosswordClue>>(CluesJson) ?? new List<CrosswordClue>();
    }

    /// <summary>
    /// Speichert Hinweise als JSON
    /// </summary>
    public void SetClues(List<CrosswordClue> clues)
    {
        CluesJson = JsonSerializer.Serialize(clues);
    }
}

