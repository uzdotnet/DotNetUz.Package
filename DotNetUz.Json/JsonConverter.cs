using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetUz.Json
{
    public static class JsonConverter
    {
        public static TSource JsonAs<TSource>(this string json)
        {
            return JsonConvert.DeserializeObject<TSource>(json);
        }
        public static string AsJson(this object ob)
        {
            return JsonConvert.SerializeObject(ob);
        }



        // GET METHOD
        public static async Task<TSource> GetJsonAsync<TSource>(this HttpClient httpClient, string? requestUrl)
        {
            var response = await httpClient.GetAsync(requestUrl);
            var content = await response.Content.ReadAsStringAsync();
            return content.JsonAs<TSource>();
        }

        public static TSource GetJson<TSource>(this HttpClient httpClient, string? requestUrl)
        {
            var response = httpClient.GetAsync(requestUrl);
            var content = response.Result.Content.ReadAsStringAsync();
            return content.Result.JsonAs<TSource>();
        }

        public static TSource GetJson<TSource>(this HttpClient httpClient, Uri? uri)
        {
            var response = httpClient.GetAsync(uri);
            var content = response.Result.Content.ReadAsStringAsync();
            return content.Result.JsonAs<TSource>();
        }



        // POST METHOD
        public static TSource PostJson<TSource>(this HttpClient httpClient, string? requestUrl, HttpContent httpContent)
        {
            var response = httpClient.PostAsync(requestUrl, httpContent);
            var result = response.Result.Content.ReadAsStringAsync();
            return result.Result.JsonAs<TSource>();
        }

        public static async Task<TSource> PostJsonAsync<TSource>(this HttpClient httpClient, string? requestUrl, HttpContent httpContent)
        {
            var response = await httpClient.PostAsync(requestUrl, httpContent);
            var result = await response.Content.ReadAsStringAsync();
            return result.JsonAs<TSource>();
        }

        public static async Task<TSource> PostJsonAsync<TSource>(this HttpClient httpClient, Uri? uri, HttpContent httpContent)
        {
            var response = await httpClient.PostAsync(uri, httpContent);
            var result = await response.Content.ReadAsStringAsync();
            return result.JsonAs<TSource>();
        }
    }
}
