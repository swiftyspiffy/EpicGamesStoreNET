using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EpicGamesStoreNET
{
    public static class Query
    {
        private static readonly string epicGamesStoreGqlEndpoint = "https://graphql.epicgames.com/graphql";
        private static readonly string postPayload = @"{""method"":""post"",""headers"":{""Content-Type"":""application/graphql""},""query"":""\n        query searchQuery(\n            $namespace: String!, \n            $locale: String!, \n            $country: String!, \n            $query: String!,\n            \n    $hasCountryFilter: Boolean,\n    $filterCountry: String,\n    $filterAgeGroup: Int\n\n            )\n        { Catalog {\n            catalogOffers(namespace: $namespace, locale: $locale, params: {\n              keywords: $query,\n              country: $country\n            }, \ncountryAgeFilter: {\n    shouldCheck: $hasCountryFilter,\n    filterCountry: $filterCountry,\n    filterAgeGroup: $filterAgeGroup\n}\n) {\n                elements {\n                    url\n                    title\n                    id\n                    price(country: $country) {\n                        totalPrice {\n                            discountPrice\n                            originalPrice\n                            fmtPrice(locale:$locale) {\n                                originalPrice\n                                discountPrice\n                        }\n                        }\n                    }\n                    productSlug\n                    categories {\n                    path\n                    }\n                }\n            }\n          }\n        }"",""variables"":{""namespace"":""epic"",""locale"":""en-US"",""query"":""[PLACEHOLDER_SEARCH]"",""country"":""US"",""hasCountryFilter"":false,""filterCountry"":null,""filterAgeGroup"":null}}";

        private static readonly HttpClient client = new HttpClient();

        public static Models.Response Search(string query)
        {
            return SearchAsync(query).GetAwaiter().GetResult();
        }

        public static async Task<Models.Response> SearchAsync(string query)
        {
            var request = new Models.Request(query);
            var payload = JsonConvert.SerializeObject(request);

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("*/*"));

            var method = new HttpMethod("POST");
            HttpContent body = new StringContent(payload);
            body.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var resp = await client.PostAsync(epicGamesStoreGqlEndpoint, body);
            var respString = await resp.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Models.Response>(respString);
        }
    }
}
