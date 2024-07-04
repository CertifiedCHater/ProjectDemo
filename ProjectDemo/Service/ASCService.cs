using ProjectDemo.Model;
using System.Text.Json;


namespace ProjectDemo.Service;

public partial class ASCService : IASCService
{
    HttpClient _httpClient;
    public ASCService()
    {
        this._httpClient = new HttpClient();

        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
    }

    List<Data> artList = new();
    public async Task<List<Data>> GetArts()
    {
        if (artList?.Count > 0)
            return artList;

        string urlData = $"https://api.artic.edu/api/v1/artworks?page=1&limit=10";
        var responseData = await _httpClient.GetStringAsync(urlData);
        var rootData = JsonDocument.Parse(responseData).RootElement;


        if (rootData.TryGetProperty($"data", out var dataNodeDemo))
        {
            foreach (var item in dataNodeDemo.EnumerateArray())
            {
         

                var artData = new Data
                {
                    title = item.GetProperty("title").ToString(),
                    place_of_origin = item.GetProperty("place_of_origin").ToString(),
                    artist_display = item.GetProperty("artist_display").ToString()
                    //artist_id = Convert.ToInt32(item.GetProperty("artist_id").ToString()),
                    //material_id = item.GetProperty("material_id").ToString(),
                    //image_id = item.GetProperty("image_id").ToString()
                };
                artList.Add(artData);
            }
        }

        return artList;
    }
}
