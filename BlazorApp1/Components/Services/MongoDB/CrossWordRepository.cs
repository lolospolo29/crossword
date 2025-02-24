using BlazorApp1.Components.Models;
using MongoDB.Driver;

public class CrossWordRepository
{
    private IMongoClient _client;

    public CrossWordRepository(IMongoClient client)
    {
        _client = client;
    }

    public async Task<List<CrosswordPuzzle>> GetAllCrosswordPuzzlesAsync()
    {
        var database = _client.GetDatabase("CrossWord");
        var collection = database.GetCollection<CrosswordPuzzle>("CrossWordPuzzle");

        return await collection.Find(_ => true).ToListAsync(); // Fetch all documents
    }
}