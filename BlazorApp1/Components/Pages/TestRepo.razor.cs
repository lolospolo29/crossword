using Microsoft.AspNetCore.Components;
using BlazorApp1.Components.Models;

namespace BlazorApp1.Components.Pages;
public partial class TestRepo : ComponentBase
{
    [Inject]
    public CrossWordRepository CrossWordRepository { get; set; } = null!; // Initialize to null or use required modifier

    protected async void FetchDocument()
    {
        List<CrosswordPuzzle> res = await CrossWordRepository.GetAllCrosswordPuzzlesAsync();   
        Console.WriteLine(res.ToString()); 
    }

    protected async void UploadDocument()
    {
        CrosswordPuzzle crossword = new CrosswordPuzzle
        {
            Title = "Mein erstes Kreuzworträtsel",
            GridJson = "[[\"H\",\"A\",\"L\",\"L\",\"O\"],[\" \",\" \",\"E\",\" \",\" \"],[\"W\",\"E\",\"L\",\"T\",\" \"]]", // 2D-Array als JSON
            CluesJson = "[{\"Clue\": \"Begrüßung\", \"Answer\": \"HALLO\", \"Row\": 0, \"Col\": 0, \"IsHorizontal\": true}, {\"Clue\": \"Unser Planet\", \"Answer\": \"WELT\", \"Row\": 2, \"Col\": 0, \"IsHorizontal\": true}]", 
            CreatedAt = DateTime.UtcNow
        };
        await CrossWordRepository.InsertCrosswordPuzzleAsync(crossword);   
        Console.WriteLine("Crossword puzzle uploaded successfully."); 
    }
}