using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using MongoDB.Bson;

namespace BlazorApp1.Components.Models;

public class CrosswordPuzzle
{
    public ObjectId Id { get; set; }

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
}
