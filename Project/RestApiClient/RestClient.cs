using InstrumentShop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentShop.RestApiClient
{
    public static class RestClient
    {
        public const string Url = "http://localhost:8080";
        public async static Task<IList<CategoryListItemModel>> ListCategoryNamesAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string result = await
                httpClient.GetStringAsync($"{Url}/api/category/listnames");
                return
                JsonConvert.DeserializeObject<List<CategoryListItemModel>>(result);
            }
        }
        public async static Task<IList<CategoryModel>> ListCategoryAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string result = await httpClient.GetStringAsync($"{Url}/api/category/list");
                return JsonConvert.DeserializeObject<List<CategoryModel>>(result);
            }
        }

        public async static Task<CategoryModel> GetCategoryAsync(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<CategoryModel>(await httpClient.GetStringAsync($"{Url}/api/category/get?id=" + id));
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
        public async static Task<int> AddCategoryAsync(CategoryModel category)
        {
            return await AddOrUpdateAsync(category, $"{Url}/api/category/add", "POST");
        }

        public async static Task<int> UpdateCategoryAsync(CategoryModel category)
        {
            return await AddOrUpdateAsync(category, $"{Url}/api/category/update", "PUT");
        }

        public async static Task DeleteCategoryAsync(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.DeleteAsync($"{Url}/api/category/delete?id={id}");
                responseMessage.EnsureSuccessStatusCode();
            }
        }

    }
}
