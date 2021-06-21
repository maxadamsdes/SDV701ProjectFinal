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
        public async static Task<IList<InstrumentListItemModel>> ListInstrumentNamesAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string result = await
                httpClient.GetStringAsync($"{Url}/api/instrument/listinstruments");
                return
                JsonConvert.DeserializeObject<List<InstrumentListItemModel>>(result);
            }
        }
        public async static Task<IList<OrderListItemModel>> ListOrderNamesAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string result = await
                httpClient.GetStringAsync($"{Url}/api/order/listnames");
                return
                JsonConvert.DeserializeObject<List<OrderListItemModel>>(result);
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
        public async static Task<IList<InstrumentModel>> ListInstrumentsAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string result = await httpClient.GetStringAsync($"{Url}/api/instrument/list");
                return JsonConvert.DeserializeObject<List<InstrumentModel>>(result);
            }
        }
        public async static Task<IList<OrderModel>> ListOrdersAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string result = await httpClient.GetStringAsync($"{Url}/api/orders/list");
                return JsonConvert.DeserializeObject<List<OrderModel>>(result);
            }
        }

        public async static Task<CategoryModel> GetCategoryAsync(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<CategoryModel>(await httpClient.GetStringAsync($"{Url}/api/category/get?id=" + id));
            }
        }
        public async static Task<InstrumentModel> GetInstrumentAsync(int? id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<InstrumentModel>(await httpClient.GetStringAsync($"{Url}/api/instrument/get?id=" + id));
            }
        }
        public async static Task<OrderModel> GetOrderAsync(int? id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<OrderModel>(await httpClient.GetStringAsync($"{Url}/api/order/get?id=" + id));
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

        public async static Task<int> AddInstrumentAsync(InstrumentModel instrument)
        {
            return await AddOrUpdateAsync(instrument, $"{Url}/api/instrument/add", "POST");
        }

        public async static Task<int> AddOrderAsync(OrderModel order)
        {
            return await AddOrUpdateAsync(order, $"{Url}/api/order/add", "POST");
        }

        public async static Task<int> UpdateCategoryAsync(CategoryModel category)
        {
            return await AddOrUpdateAsync(category, $"{Url}/api/category/update", "PUT");
        }
        public async static Task<int> UpdateInstrumentAsync(InstrumentModel instrument)
        {
            return await AddOrUpdateAsync(instrument, $"{Url}/api/instrument/update", "PUT");
        }
        public async static Task<int> UpdateOrderAsync(OrderModel order)
        {
            return await AddOrUpdateAsync(order, $"{Url}/api/order/update", "PUT");
        }
        public async static Task DeleteCategoryAsync(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.DeleteAsync($"{Url}/api/category/delete?id={id}");
                responseMessage.EnsureSuccessStatusCode();
            }
        }
        public async static Task DeleteInstrumentAsync(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.DeleteAsync($"{Url}/api/instrument/delete?id={id}");
                responseMessage.EnsureSuccessStatusCode();
            }
        }
        public async static Task DeleteOrderAsync(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.DeleteAsync($"{Url}/api/order/delete?id={id}");
                responseMessage.EnsureSuccessStatusCode();
            }
        }
    }
}
