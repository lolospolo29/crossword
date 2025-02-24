using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages;
public partial class TestRepo : ComponentBase
{
    [Inject]
    public CrossWordRepository CrossWordRepository { get; set; }

    protected async void FetchDocument()
    {
        var res = await CrossWordRepository.GetAllCrosswordPuzzlesAsync();   
        Console.WriteLine(res); 
    }
    protected async void UploadDocument()
    {
        var res = await CrossWordRepository.GetAllCrosswordPuzzlesAsync();   
        Console.WriteLine(res); 
    }
}