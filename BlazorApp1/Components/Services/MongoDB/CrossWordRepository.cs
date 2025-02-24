using MongoDB.Driver;

public class CrossWordRepository
{
    private IMongoClient _client;

    public CrossWordRepository(IMongoClient client)
    {
        _client = client;
    }

    public IMongoCollection<CrosswordPuzzle> GetCollection()
    {
        var database = _client.GetDatabase("CrosswordPuzzles");
        return database.GetCollection<CrosswordPuzzle>("CrosswordPuzzles");
    }

}