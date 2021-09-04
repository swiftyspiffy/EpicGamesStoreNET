using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace EpicGamesStoreNET
{
    public static class Query
    {
        private static readonly string epicGamesStoreGqlEndpoint = "https://graphql.epicgames.com/graphql";
        private static readonly HttpClient client = new HttpClient();

        public static Models.Response Search(string query)
        {
            return SearchAsync(query).GetAwaiter().GetResult();
        }

        public static async Task<Models.Response> SearchAsync(string query)
        {
            var encoded = HttpUtility.UrlEncode(query).Replace(":", "%3A");
            var request = new Models.Request(encoded);
            var payload = JsonConvert.SerializeObject(request);

            var method = new HttpMethod("POST");
            HttpContent body = new StringContent(payload);
            body.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var resp = await client.PostAsync(epicGamesStoreGqlEndpoint, body);
            var respString = await resp.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Models.Response>(respString);
        }
    }
}
