
using Newtonsoft.Json;
using ProjectDemo.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace ProjectDemo.Service;

public partial class ASCService : IASCService
{
    HttpClient _httpClient;
    public ASCService()
    {
        this._httpClient = new HttpClient();
    }

    List<Art> artList;
    public async Task<List<Art>> GetArts()
    {
        if (artList?.Count > 0)
            return artList;

        string urlData = $"https://api.artic.edu/api/v1/artworks?page=1&limit=100";
        var responseData = await _httpClient.GetStringAsync(urlData);
        var rootData = JsonDocument.Parse(responseData).RootElement;
        var art_demo = new Art
        {
            data = new List<Data>(),
            info = new Info(),
            config = new Config(),
        };

        art_demo.info.version = rootData.GetProperty("Version").GetString();
        art_demo.info.license_text = rootData.GetProperty("License text").GetString();

        art_demo.config.website_url = rootData.GetProperty("").GetString();
        art_demo.config.iiif_url = rootData.GetProperty("").GetString();

        if (rootData.TryGetProperty($"Picture Data ", out var dataNodeDemo))
        {
            foreach (var item in dataNodeDemo.EnumerateObject())
            {
          
                var artValue = item.Value;

                var artData = new Data
                {
                    title = artValue.GetProperty("1. title").ToString(),
                    place_of_origin = artValue.GetProperty("2. place of origin").ToString(),
                    edition = artValue.GetProperty("3. edition").ToString,
                    artist_id = Convert.ToInt32(artValue.GetProperty("4. artist id").ToString()),
                    material_id = artValue.GetProperty("5. material id").ToString(),
                    image_id = artValue.GetProperty("6. image id").ToString() 
                };
            }
        }

        return artList;
    }
}
