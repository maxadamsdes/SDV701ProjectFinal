using ArtGallery.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.RestApiClient
{
    public static class RestClient
    {
        public const string Url = "http://localhost:8080";
        public async static Task<IList<ArtistListItemModel>> ListArtistNamesAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string result = await
                httpClient.GetStringAsync($"{Url}/api/artist/listnames");
                return
                JsonConvert.DeserializeObject<List<ArtistListItemModel>>(result);
            }
        }
        public async static Task<IList<ArtistModel>> ListArtistAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string result = await httpClient.GetStringAsync($"{Url}/api/artist/list");
                return JsonConvert.DeserializeObject<List<ArtistModel>>(result);
            }
        }

        public async static Task<ArtistModel> GetArtistAsync(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<ArtistModel>(await httpClient.GetStringAsync($"{Url}/api/artist/get?id=" + id));
            }
        }

        private async static Task<int> AddOrUpdateAsync<T>(T model, string url, string request)
        {
            using (HttpRequestMessage requestMessage = new HttpRequestMessage(new HttpMethod(request), url))
            using (requestMessage.Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json"))
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.SendAsync(requestMessage);
                responseMessage.EnsureSuccessStatusCode();
                return Convert.ToInt32(await responseMessage.Content.ReadAsStringAsync());
            }
        }
        public async static Task<int> AddArtistAsync(ArtistModel artist)
        {
            return await AddOrUpdateAsync(artist, $"{Url}/api/artist/add", "POST");
        }

        public async static Task<int> UpdateArtistAsync(ArtistModel artist)
        {
            return await AddOrUpdateAsync(artist, $"{Url}/api/artist/update", "PUT");
        }

        public async static Task DeleteArtistAsync(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.DeleteAsync($"{Url}/api/artist/delete?id={id}");
                responseMessage.EnsureSuccessStatusCode();
            }
        }

    }
}
